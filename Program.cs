using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static int MultiplyByTwo(int value)
        {
            return value * 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linq");

            var scores = new List<int> { 42, 100, 98, 15 };
            Console.WriteLine(string.Join(", ", scores));

            //Here is our handy multiply by two function
            // Func<int, int> MultiplyByTwo = value => value * 2;

            //Make a new list to store the results 
            var newScores = new List<int>();

            //Go through each score in the scores list
            foreach (var score in scores)
            {
                //use the 'MultiplyByTwo' function expression to take the score and double it
                var doubled = MultiplyByTwo(score);
                //add it to the new list 
                newScores.Add(doubled);
            }
            //print the list of newScore to the console
            Console.WriteLine(string.Join(", ", newScores));
            //Another example of using a function expression
            // Func<Employee, string, bool> EmployeeHasName = (employee, name) == EmployeeHasName.Name == name;
            // if (EmployeeHasName(employee, "Bob"))
            // {
            //     Console.WriteLine("Yup, that is Bob!");
            // }
        }
    }
}
