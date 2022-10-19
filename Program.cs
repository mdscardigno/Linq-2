﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{

    class Movie
    {
        //These are all the things a Movie knows about:
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Tagline { get; set; }
        public DateTime ReleasedDate { get; set; }
        public int Screenings { get; set; }
        public double PricePerTicket { get; set; }
        public double TotalRevenue { get; set; }
        public double Cost { get; set; }
        public double Budget { get; set; }

        //behavior of Movie
        public double RevenuePerScreenings()
        {
            return TotalRevenue / Screenings;
        }

    }

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

            var listOfFilms = new List<Movie>()
            {
                new Movie(){
                    Id = 1,
                    Name = "Dorm Daze (National Lampoon Presents Dorm Daze)",
                    Tagline = "Multi-tiered modular standardization",
                    ReleasedDate = DateTime.Parse("3/27/2019"),
                    Screenings = 186,
                    PricePerTicket = 11,
                    TotalRevenue = 13361359,
                    Cost = 18274829,
                    Budget = 8210089
                },
                new Movie()
                {
                    Id = 2,
                    Name = "Born Yesterday",
                    Tagline = "Managed empowering open system",
                    ReleasedDate = DateTime.Parse("2/12/2014"),
                    Screenings = 184,
                    PricePerTicket = 11,
                    TotalRevenue = 6563796,
                    Cost = 9021912,
                    Budget = 11364786
                },
                new Movie()
                {
                    Id = 3,
                    Name = "Darjeeling Limited, The",
                    Tagline = "Quality-focused actuating initiative",
                    ReleasedDate = DateTime.Parse("8/21/2013"),
                    Screenings = 177,
                    PricePerTicket = 10,
                    TotalRevenue = 17851792,
                    Cost = 5441889,
                    Budget = 12144397
                },
                new Movie()
                {
                    Id = 4,
                    Name = "Offside",
                    Tagline = "Enhanced homogeneous migration",
                    ReleasedDate = DateTime.Parse("4/18/2019"),
                    Screenings = 169,
                    PricePerTicket = 11,
                    TotalRevenue = 1445952,
                    Cost = 4008467,
                    Budget = 7417825
                },
                new Movie()
                {
                    Id = 5,
                    Name = "Superman vs. The Elite",
                    Tagline = "Stand-alone systematic model",
                    ReleasedDate = DateTime.Parse("12/7/2016"),
                    Screenings = 124,
                    PricePerTicket = 19,
                    TotalRevenue = 13737676,
                    Cost = 18893333,
                    Budget = 6585110
                },
                new Movie()
                {
                    Id = 6,
                    Name = "Body Snatchers",
                    Tagline = "Diverse holistic data-warehouse",
                    ReleasedDate = DateTime.Parse("1/12/2007"),
                    Screenings = 170,
                    PricePerTicket = 10,
                    TotalRevenue = 10540575,
                    Cost = 12946787,
                    Budget = 9237906
                },
                new Movie()
                {
                    Id = 7,
                    Name = "Death and Cremation",
                    Tagline = "Ergonomic local knowledge base",
                    ReleasedDate = DateTime.Parse("4/1/2013"),
                    Screenings = 138,
                    PricePerTicket = 10,
                    TotalRevenue = 12361644,
                    Cost = 7326663,
                    Budget = 16829534
                },
                new Movie()
                {
                    Id = 8,
                    Name = "Other End of the Line, The",
                    Tagline = "Up-sized demand-driven policy",
                    ReleasedDate = DateTime.Parse("11/15/2016"),
                    Screenings = 169,
                    PricePerTicket = 12,
                    TotalRevenue = 6371172,
                    Cost = 17279838,
                    Budget = 14274676
                },
                new Movie()
                {
                    Id = 9,
                    Name = "Our Mother's House",
                    Tagline = "Enhanced methodical algorithm",
                    ReleasedDate = DateTime.Parse("7/20/2018"),
                    Screenings = 188,
                    PricePerTicket = 17,
                    TotalRevenue = 3544170,
                    Cost = 7953388,
                    Budget = 19636220
                },
                new Movie()
                {
                    Id = 10,
                    Name = "Everything I Can See From Here",
                    Tagline = "Synchronized 24/7 utilization",
                    ReleasedDate = DateTime.Parse("7/26/2012"),
                    Screenings = 84,
                    PricePerTicket = 4,
                    TotalRevenue = 14520267,
                    Cost = 2766779,
                    Budget = 2478292
                },
                new Movie()
                {
                    Id = 11,
                    Name = "My Rainy Days",
                    Tagline = "Cloned static array",
                    ReleasedDate = DateTime.Parse("8/4/2015"),
                    Screenings = 104,
                    PricePerTicket = 15,
                    TotalRevenue = 6860536,
                    Cost = 6622076,
                    Budget = 1091525
                },
                new Movie()
                {
                    Id = 12,
                    Name = "Five Graves to Cairo",
                    Tagline = "Ergonomic heuristic capacity",
                    ReleasedDate = DateTime.Parse("10/25/2013"),
                    Screenings = 65,
                    PricePerTicket = 17,
                    TotalRevenue = 13595001,
                    Cost = 3736299,
                    Budget = 724740
                },
                new Movie()
                {
                    Id = 13,
                    Name = "Hunted, The",
                    Tagline = "Multi-channelled object-oriented groupware",
                    ReleasedDate = DateTime.Parse("2/4/2014"),
                    Screenings = 185,
                    PricePerTicket = 7,
                    TotalRevenue = 13273082,
                    Cost = 14879296,
                    Budget = 7461416
                },
                new Movie()
                {
                    Id = 14,
                    Name = "Charlie Chan's Courage",
                    Tagline = "Implemented interactive installation",
                    ReleasedDate = DateTime.Parse("5/25/2006"),
                    Screenings = 50,
                    PricePerTicket = 10,
                    TotalRevenue = 15695655,
                    Cost = 11372062,
                    Budget = 9089553
                },
                new Movie()
                {
                    Id = 15,
                    Name = "When Will I Be Loved",
                    Tagline = "Networked uniform toolset",
                    ReleasedDate = DateTime.Parse("8/25/2015"),
                    Screenings = 165,
                    PricePerTicket = 21,
                    TotalRevenue = 10095292,
                    Cost = 16020659,
                    Budget = 15707348
                },
                new Movie()
                {
                    Id = 16,
                    Name = "Viva Las Vegas",
                    Tagline = "Digitized dedicated capability",
                    ReleasedDate = DateTime.Parse("7/4/2015"),
                    Screenings = 85,
                    PricePerTicket = 16,
                    TotalRevenue = 16406383,
                    Cost = 9854228,
                    Budget = 16042287
                },
                new Movie()
                {
                    Id = 17,
                    Name = "Topaze",
                    Tagline = "Advanced high-level benchmark",
                    ReleasedDate = DateTime.Parse("12/1/2010"),
                    Screenings = 60,
                    PricePerTicket = 4,
                    TotalRevenue = 13809680,
                    Cost = 12667720,
                    Budget = 14805773
                },
                new Movie()
                {
                    Id = 18,
                    Name = "The Clinic",
                    Tagline = "Polarized regional solution",
                    ReleasedDate = DateTime.Parse("4/20/2013"),
                    Screenings = 128,
                    PricePerTicket = 8,
                    TotalRevenue = 17416537,
                    Cost = 3435812,
                    Budget = 8818065
                },
                new Movie()
                {
                    Id = 19,
                    Name = "The Land Before Time X: The Great Longneck Migration",
                    Tagline = "Adaptive dedicated workforce",
                    ReleasedDate = DateTime.Parse("10/10/2008"),
                    Screenings = 170,
                    PricePerTicket = 21,
                    TotalRevenue = 5720197,
                    Cost = 10514309,
                    Budget = 3781872
                },
                new Movie()
                {
                    Id = 20,
                    Name = "Tarzan",
                    Tagline = "Polarized intangible productivity",
                    ReleasedDate = DateTime.Parse("12/31/2006"),
                    Screenings = 105,
                    PricePerTicket = 19,
                    TotalRevenue = 6338974,
                    Cost = 18402771,
                    Budget = 844331
                },
                new Movie()
                {
                    Id = 21,
                    Name = "Jaws",
                    Tagline = "When a killer shark unleashes chaos on a beach community, it's up to a local sheriff, a marine biologist, and an old seafarer to hunt the beast down. ",
                    ReleasedDate = DateTime.Parse("1/1/1975"),
                    Screenings = 105,
                    PricePerTicket = 7,
                    TotalRevenue = 6338974,
                    Cost = 18402771,
                    Budget = 844331
                }
            };//end of movie list

            Console.WriteLine($"There are {listOfFilms.Count()} total movies");

            //movies is a list of movies and movie is a single movie
            var movieNames = listOfFilms.Select(film => film.Name);
            //if things is a list of book then thing is a book
            //if plural is a list of things then singular is a thing
            //if cars is a list of car then car is a car
            //So now this averages is going to be a IEnumerable of doubles
            var averages = listOfFilms.Select(film => film.RevenuePerScreenings());

            //there are two variables bellow
            //the first variable is a list of the things in the list
            //the second variable is index which will be an integer which is counting 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20
            //I can build a new string as shown below
            //mode one select with one variable
            var movieNamesWithIndex = listOfFilms.Select((film, index) => $"The movie named {film.Name} is at position {index}");
            var tacoTuesdays = listOfFilms.Select((film, index) => index * film.Budget);
            //example with tuples
            //mode two select with two variables
            //each film is popping out of listOfFilms and index is is a number Select is helping me with: this film is at index 1, this fil is at index 2, .... in case I need it
            var tacoTuesdayTuple = listOfFilms.Select((film, index) => new Tuple<int, string>(index, film.Name));

            //
            //ANOTHER METHOD OF LINQ
            //
            //Where statement is like a filter. We use it when we want to make a new list, keeping only some of the items from the original list.
            //Make a new list, of equal or smaller size by running an expression against every item. keeping only items when the expression returns true.
            //Where cannot change the data.
            //Go through the list and only keep the ones that meet the criteria, thats when Where comes into place
            //In the left side of a Where we are asking a boolean question
            //gets a list of the popular films
            var popularFilms = listOfFilms.Where(film => film.Screenings >= 100);

            //Combining Select and Where
            //If you are not accurate in your words, you are not accurate on your thinking
            //.... and if you are not accurate on your thinking, you are not accurate on your results
            //now translate the list of the movies to the list of movie names
            var popularFilmNames = popularFilms.Select(film => film.Name);
            //chained together
            //I don't have to put it inside of a variable. Putting it inside a variable gives me a name for it
            var popularFilmNamesInOneStep = listOfFilms.Where(film => film.Screenings >= 100).Select(film => film.Name);
            // foreach (var x in popularFilms)
            // {
            //     Console.WriteLine(x.Name);
            // }
            // //THIS DOES THE SAME THING
            // foreach (var x in popularFilmNames)
            // {
            //     Console.WriteLine(x);
            // }
            //Console.WriteLine(String.Join(",", popularFilmNames));

            //Aggregate often called reduce in other languages.
            //The Aggregate method takes the list and processes it down into a single value.
            //Returns a single value. It starts with a value we will call the current value. The given expression gets to use, one at a time, the current value and the item from the list, returning
            //a new current value.
            //Snake that eats its own tail
            //Find the total revenue for all movies
            //var TotalRevenue = movieNames.Aggregate((current, next) => current + next);

            //Finding the total revenue for all movies
            // var totalRevenue = listOfFilms.Aggregate((0.0, (currentTotal, film) => currentTotal + film.TotalRevenue));
            //Sum
            //In this example we first take all the movies and use Select to generate a new list of all the revenues. Then we use Sum to add up the values.
            //Simpler than Aggregate
            var allRevenues = listOfFilms.Select(film => film.TotalRevenue);
            var totalRevenue = allRevenues.Sum();
            Console.WriteLine(totalRevenue);

            var totalRevenueOneStep = listOfFilms.Sum(film => film.TotalRevenue);
            var totalScreenings = listOfFilms.Sum(film => film.Screenings);
            //All method
            //Returns a single bool which will be true if the expression is true for every element in the list.
            //Returns a boolean if the expression evaluates to true for every element in the list.

            //Figure out if all the movies are old movies, before 1965
            var areAllOldMovies = listOfFilms.All(film => film.ReleasedDate.Year < 1965);

            //Any
            //Returns a boolean if there is even a single element in the lost that causes the expression to return true.
            //Figure out if there is even a single old movie before 1965 in our list
            var areAnyOldMovies = listOfFilms.Any(film => film.ReleasedDate.Year < 1965);
            //Get count of movies that cost more than $10 to see
            var moviesThatCostMoreThanTenDollars = listOfFilms.Count(film => film.PricePerTicket > 10);
            //this is kind of the same
            var anotherWayOfCountingMoviesCostingMoreThanTenDollars = listOfFilms.Where(film => film.PricePerTicket > 10).Count();
            Console.WriteLine($"There is {anotherWayOfCountingMoviesCostingMoreThanTenDollars} that cost more than $10.");
            //First method
            //First returns a single element from the list which is the first item for which the expression returns true. If no item is found, an exception is thrown.
            //Our favorite movie is Jaws
            //Let's get it from the lost if it is there. If it isn't well get an exemption / error.
            // var favoriteMovie = listOfFilms.First(film => film.Name == "Jaws");
            //Unhandled Exemption
            // var favoriteMovie = listOfFilms.First(film => film.Name == "Back to the Future");
            //Null Exception
            var favoriteMovie = listOfFilms.FirstOrDefault(film => film.Name == "Back to the Future");
            //guarding if to check if a variable is null
            if (favoriteMovie == null)
            {
                //variable is null and not ok to use
                Console.WriteLine("Nope, no such a movie!.");
            }
            else
            {
                //variable is not null and is a totally fine 'Movie' object to use
                Console.WriteLine($"The budget for {favoriteMovie.Name} was {favoriteMovie.Budget}");
            }

            //Unit 3 we will learn how to handle exceptions
            //There are more methods in LINQ: FindIndex, First, FirstOrDefault, Last, LastOrDefault, Distinct, Sum, Take, Skip, OrderBy, OrderByIncreasing, OrderByDescending, ThenBy...
            //Take and Skip do pagination
            //These are the most used methods in LINQ
            //Look at the quick reference guide for linq and refresh what each method does


        }
    }
}
