using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();
            
            //Create a variable of type int and initialize the variable with a value of 0
            int sum =0;


            // Create a do-while loop
            do 
            { 
             
              sum++;
                // Increment your variable by 1

                // Then add your variable to "numbers"
                numbers.Add(sum);
            }
            // While your variable is less than 100
            while(sum<100);
                


            // Create a while loop
            // While your variable is less than 200
            while(sum<200)
            {
                sum++;
                numbers.add(sum);
                // Increment your variable by 1
                // Then add your variable to "numbers"
            }

            Console.WriteLine("Increase:");

            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }
            // Create a foreach loop
            // Write your variable to the console

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            for(i= 199; i <= numbers.Count && i >=0; i--)
            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            {
                Console.WriteLine($"{numbers[i]}");
                // Write to the console "numbers" at index i
            }
        }
    }
}
