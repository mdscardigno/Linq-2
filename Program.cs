using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        // static int MultiplyByTwo(int value)
        // {
        //     return value * 2;
        // }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linq");

            var scores = new List<int> { 42, 100, 98, 15 };
            // Console.WriteLine(string.Join(", ", scores));

            //Function expressions seem like they can behave like methods
            //Function expressions and methods are identical except for that we can treat the code in the function expression as if it were a variable
            //We will see this concept in JS
            //This is a feature from Functional Programming/Languages
            //Functional languages treat code as if they were variables and can be passed around as if they were an Integer, Object, Boolean or String
            //We are treating code like data
            //MultiplyingByTwo is a local variable
            //Of Type Func<int, int>
            //It's name is MultiplyByTwo
            //Here is our handy multiply by two function
            // Func<int, int> MultiplyByTwo = value => value * 2;
            //NOTE: If you create a variable one time and you use it in only one place, we replace what it does with the name
            // so in the case of the function expression above, we can take value => value * 2 and replace MultiplyByTwo with what it does or the expression itself
            //see bellow on newScores variable
            // //OLD WAY
            // //Make a new list to store the results 
            // var newScores = new List<int>();

            // //Go through each score in the scores list
            // foreach (var score in scores)
            // {
            //     //use the 'MultiplyByTwo' function expression to take the score and double it
            //     var doubled = MultiplyByTwo(score);
            //     //add it to the new list 
            //     newScores.Add(doubled);
            // }
            // //print the list of newScore to the console
            // Console.WriteLine(string.Join(", ", newScores));


            //Another example of using a function expression
            // Func<Employee, string, bool> EmployeeHasName = (employee, name) == EmployeeHasName.Name == name;
            // if (EmployeeHasName(employee, "Bob"))
            // {
            //     Console.WriteLine("Yup, that is Bob!");
            // }

            //LINQ METHODS:
            // SELECT: Generic Method and can work with any expression we give it 
            //
            //NEW WAY - LINQ
            //IEnumerable means they are countable and and we can work our way through them in some sequence
            //It does not return a new list. What returns is a IEnumerable which talks like the list, walks like the list, so we can just treated like a list
            //
            //
            // var newScores = scores.Select(value => value * 2);// this in other programming languages can be Map or Reduce to transform data which is the same as a select
            //we are now to change the name of the variable we are passing in to the function expression from value to score
            var newScores = scores.Select(score => score * 2);
            var slightlyBetterDoubleScores = newScores.Select(score => score + 1);// as long as that transform works in Integers, we can use it to transform it any way we like
            //So the statement above will read: newScores is going to be the old scores projected/selected/transformed by taking each score and multiplying it by 2
            //
            // foreach (var score in newScores)
            // {
            //     Console.WriteLine(score);
            // }
            //Small differences between an IEnumerable and a List
            // Console.WriteLine(scores.Count); //We can use Count() on a List 
            // Console.WriteLine(newScores.Count());//once we have an IEnumerable Count becomes a method and not longer a property

            // Console.WriteLine(string.Join(", ", newScores));
        }
    }
}
