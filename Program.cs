using System;
using System.Collections.Generic;
namespace Lab_4._2_Movies
{
    public class Movie
    {
        //Private variables
        private string _category;
        private string _title;

        //Getters
        public string Title
        {
            get
            {
                return _title;
            }
        }
        public string Category
        {
            get
            {
                return _category;
            }
        }

        //Constructor
        public Movie(string category, string title)
        {
            _category = category;
            _title = title;
        }
    }
    class Program
    {
        //Restart Method
        static void Restart()
        {
            //Method called to restart.
            Console.WriteLine("");
            Console.WriteLine("Quit?. Y/N?");
            string y = Console.ReadLine().ToLower();
            if (y == "y")
            {
                Environment.Exit(1);
            }
            else
            {
                Console.Clear();
                Main();
            }
        }
        static void Main()
        {
            //Place each instance of Movie inside of the List of movies.
            List<Movie> movies = new List<Movie>
            {
                new Movie("Action", "The Raid"),
                new Movie("Action", "Casino Royale"),
                new Movie("Action", "Mad Max: Fury Road"),
                new Movie("Action", "Encounters of the Spooky Kind"),
                new Movie("Drama", "The Departed"),
                new Movie("Drama", "The Dark Knight"),
                new Movie("Drama", "American Psycho"),
                new Movie("Drama", "Full Metal Jacket"),
                new Movie("SciFi", "Beyond the Black Rainbow"),
                new Movie("SciFi", "Interstellar"),
                new Movie("SciFi", "Snowpiercer"),
                new Movie("Comedy", "Happy Gilmore"),
                new Movie("Comedy", "The Big Short"),
                new Movie("Comedy", "Office Space")
            };

            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine($"Welcome to my DVD collection, I have {movies.Count} movies available.");
                Console.WriteLine("Let's choose a category. I have Action, Comedy, Drama and SciFi available.");
                string entry = Console.ReadLine().ToLower();
                Console.WriteLine("");
                //If the user entry does not equal any of the categories listed here, it will not search through the list for the category. Other categories must be manually added here:
                if (entry != "action" && entry != "drama" && entry != "scifi" && entry != "comedy")
                {
                    Console.WriteLine("That input was invalid, let's try again.");
                    Restart();
                }

                //For each movie in the list of movies, compare the category to the user's input that passed validation and grab any titles that match.
                foreach (Movie movie in movies)
                {
                    if (movie.Category.ToLower() == entry)
                    {
                        Console.WriteLine(movie.Title);
                    }
                }
                Restart();
            }
        }
    }
}
