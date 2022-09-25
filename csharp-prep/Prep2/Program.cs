using System;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 2");

            Console.Write("What is your grade percentage? ");
            string grade= Console.ReadLine();

            int x = int.Parse(grade);
            
            string letter = "";
           
            if (x >= 90)
               {
                letter = "A";
               }
            else if (x >=80)
              {
                letter = "B";
              }
            else if (x >=70)
               {
                 letter = "C";
               }
            else if (x >= 60)
               {
                 letter = "D";
               }
            else 
               {
                letter = "f";
               }
               Console.WriteLine($"Your letter grade is: {letter}");
                 
                 if (x >=70)
                     {
                    Console.WriteLine("Congratulations! You passed the class!");
                    }
                 else 
                    {
                       Console.WriteLine("Stay focused and you'll get it next time!");
                    }
        } 
        
          
    }
}
