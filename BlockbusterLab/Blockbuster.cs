using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class Blockbuster
    {
        public List<Movie> Movies = new List<Movie>();

        public Blockbuster()
        {
            //creating list of movies and adding categories, runtime and scenes
            Movies.Add(new DVD("Titanc", "Drama", 194, new List<string> { "I'm the king of the world!", "Rose and Jack on the deck", "Cal and Rose Fighting", "Rose and her mother arguing", "Titanic going down" }));
            Movies.Add(new DVD("Steve Jobs", "Drama", 122, new List<string> { "Steve Jobs vs Wozniak", "Steve Jobs talking to his daughter", "Wozniak talking to Steve Jobs's daughter", "Steve Jobs giving a speech", "Wozniak yelling at Steve"}));
            Movies.Add(new DVD("The Gladiator", "Action", 155, new List<string> { "Marcus Aurelius & Maximus talk of Rome and Home", "Battle scene", "My name is Maximus", "Battle with a retired gladiator", "Arena"}));
            Movies.Add(new VHS("The Lion King", "Comedy", 90, new List<string> {"Mufasa saved Simba", "Circle of life","Simba singing about being a kind", "Can you feel the love tonight?","Nala tells Simba to go back to save the kingdom" }));
            Movies.Add(new VHS("Alladin", "Romance", 90, new List<string> { "Magic carpet ride", "Aladdin talking to the genie", "Aladdin making a wish to become a prince", "Genie making the first wish happen", "Princess meeting Prince Ali"}));
            Movies.Add(new VHS("Alien", "Horror", 120, new List<string> { "Aliens invading the planet", "Aliens fighting the human race", "Robots fighting aliens", "big bomb on the ship","Alines taking off"}));
            Movies.Add(new VHS("Sweet Girl", "Drama", 110, new List<string> { "Fighting", "Car bombing", " Girl running away with her dad", "Running from the thieves", "Girl meeting her dad" }));

        }


        public void PrintMovies()
        {
            for(int i = 0; i < Movies.Count; i++)
            {
                //this prints the list of movies with the index. it prints i first which is the number of the index and then it cycles through the list of movies and prints i each time it loops
                Console.WriteLine((i) + ". " + Movies[i].ToString());
               
            }
        }

        public Movie CheckOut()
        {
            Console.WriteLine("Hello! Welcome to Blockbuster!");
            Console.WriteLine("Please select a movie from the List: ");
            PrintMovies();

            Console.WriteLine("What movie would you like to watch from the list? ");
            int userSelection = int.Parse(Console.ReadLine());

            //this is accessing the movies list and uses the userSelection as an index and prints the properties added into the ToString(); and then it returns the movie based on userSelection
            Console.WriteLine(Movies[userSelection].ToString());
            return Movies[userSelection];

            

        }
    }
}
