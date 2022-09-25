using System; 
using System.Collections.Generic;

namespace SandboxProject
{
    class Program
    {
        static void Main(string[] args)
        { 
             DisplayWelcomeMessage(); 
          
            List<string> board = GetNewBoard();
            string currentPlayer = "x";

            while (!IsGameOver(board))
            {
                DisplayBoard(board);
                
               int squareChoice = GetUserChoice(currentPlayer);
               MakeMove(board, currentPlayer, squareChoice); 

               currentPlayer = GetNextPlayer(currentPlayer);
            }
             
            DisplayBoard(board);
            Console.WriteLine("Good game. Thanks for playing!");
           


        } 
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Tic Tac Toe Game!");
            Console.WriteLine();
        }
        static void DisplayBoard(List<string> board)
        {
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
        } 
        static List<string> GetNewBoard()
        {
            List<string> board = new List<string>();

            for (int i = 1; i <= 9; i++)
            {
                board.Add(i.ToString());
            }

           

            return board;
        } 
        static int GetUserChoice(string currentPlayer)
        {
            Console.Write($"{currentPlayer}'s turn to choose a square (1-9): ");
            int squareChoice = int.Parse(Console.ReadLine());
            
            return squareChoice;
        } 
        static void MakeMove(List<string> board, string currentPlayer, int squareChoice)
        {
            int boardIndex = squareChoice -1;
            board[boardIndex] = currentPlayer;
        } 
        static bool IsGameOver(List<string> board)
        {
            bool isGameOver = false;

            if (IsWinner(board, "x") || IsWinner(board, "o") || IsTie(board))
            {
                isGameOver = true;
            } 

            return isGameOver;
        } 
        static bool IsWinner(List<String> board, string player)
        {
            bool isWinner = false;

            if((board[0] == player && board[1] == player && board[2] == player)
               || (board[3] == player && board[4] == player && board[5] == player)
               || (board[6] == player && board[7] == player && board[8] == player)
               || (board[0] == player && board[3] == player && board[6] == player)
               || (board[1] == player && board[4] == player && board[7] == player)
               || (board[2] == player && board[5] == player && board[8] == player)
               || (board[0] == player && board[4] == player && board[8] == player)
               || (board[2] == player && board[4] == player && board[6] == player)
               ) 
            {
                isWinner = true;
            } 
              
              return isWinner;
        } 
        static bool IsTie(List<string> board)
        {
            bool foundDigit = false;

            foreach (string value in board)
            {
                if (char.IsDigit(value[0]))
                {
                    foundDigit = true;
                    break;
                }
            } 
            return !foundDigit;
        } 
        static string GetNextPlayer(string currentPlayer)
        {
            string nextPlayer = "x";

            if (currentPlayer == "x")
            {
                nextPlayer = "o";
            } 

            return nextPlayer;
        }
        }
        
    }

