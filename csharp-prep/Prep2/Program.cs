using System;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("This is prep 2");
         
         Console.Write("What is your grade percentage? ");
         string userInput = Console.ReadLine();
         int gradeNumber = int.Parse(userInput); 
         
         string letter = ""; 

         int remainder = gradeNumber % 10; 

         string signGrade = "";

         if (gradeNumber >= 90) {
            letter = "A";
         } 
         else if (gradeNumber >= 80) {
            letter = "B";
         } 
         else if (gradeNumber >= 70) {
            letter = "C";
         } 
         else if (gradeNumber >= 60) {
            letter = "D";
         } 
         else {
            letter = "F";  
         } 
        
        if (remainder >= 7){
             signGrade = "+";
        } 
        else if (remainder < 3) {
          signGrade = "-";
        } 
       
       //Recognize that there is no A+ grade, only A and A-.
       //Add some additional logic to your program to detect this case and handle it correctly.
        if (remainder >=7 && gradeNumber >= 97) {
         signGrade = "";
        } 
        else if (remainder < 3 && gradeNumber < 93) {
         signGrade = "-";
        } 
        //Similarly, recognize that there is no F+ or F- grades, only F. 
        //Add additional logic to your program to detect these cases and handle them correctly.
        if (gradeNumber < 60) {
         signGrade = "";
        }
        Console.WriteLine($"Your grade is {letter}{signGrade}");
         // Accessing if the user has pass the exam 
         if(gradeNumber >= 70) {
            Console.Write("Congratulation you passed the exam.");
         } 
         else {
            Console.Write("Everyone fails at some point. You will do better the next time.");
         }

        }
    }
}
