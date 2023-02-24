using System;

namespace Prep1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is prep 1");
            
            // Asking user for their first name 
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine(); 
            
            // Asking user for their last name 
            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine(); 

            // print out user last name and first name 
            Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
        }
    }
}
