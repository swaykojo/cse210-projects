using System;
using System.Collections.Generic;

namespace Prep5
{
    class Program
    {
        static void Main(string[] args)
        {
             DisplayMessage();

             string UserName =  AskUserName();
             int UserNumber =   AskUserNumber();
             int SquareUserNum = SquareUserNumber(UserNumber);

             DisplayFinalMessage(UserName, SquareUserNum);
        } 
        static void DisplayMessage() 
        {
            Console.WriteLine("Welcome to the program!");
        } 
        static string AskUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        } 
        static int AskUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }
        static int SquareUserNumber(int number)
        {
            int square = number * number;
            
            return square;
        } 
        static void DisplayFinalMessage(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}
