using System;
using System.Collections.Generic;

namespace BlockbusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing the blockbuster class.
            Blockbuster blockbuster = new Blockbuster();

            //Calling the Movie Class and assigning it a new variable and then calling the CheckOut Method inside the Blockbuster class and it displays the movie the user selected
            Movie selectedMovie = blockbuster.CheckOut();

            Console.WriteLine("Do you want to watch the movie? y/n");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "y" || userInput == "yes")
            {
                selectedMovie.Play();
            }
            else
            {
                Console.WriteLine("Okay! Have a nice day!");
            }
            
        }
    }
}

