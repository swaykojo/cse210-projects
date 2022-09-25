﻿using System;
using System.Collections.Generic;


namespace Prep4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 4");
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            List<int> numbers = new List<int>();
            
            int number =-1;

            while(number != 0)
            {
                Console.Write("Please enter a number: ");
                number = int.Parse(Console.ReadLine());
                
                if (number !=0)
                {
                   numbers.Add(number);
                }
                 
            } 
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            } 
            Console.WriteLine($"The sum is: {sum}"); 

            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}"); 

            int max = numbers[0]; 

            foreach (int num in numbers)
           {
             if (num > max)
             {
                max=num;
             }
           }
           Console.WriteLine($"The largest number is: {max}");
        }  
           
           
            
    }
} 


