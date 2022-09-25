using System;

namespace Prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 3");  

            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max + 1);

                while (guess !=number)
                {
                    Console.Write("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);
                    
                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low!");
                    } 
                    guesses++;
                }
                Console.WriteLine("You Win");
                Console.WriteLine("Guesses: " +guesses);
            }
        }  
        




        }
    }

