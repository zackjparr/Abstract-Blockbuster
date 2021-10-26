using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class VHS : Movie

        
    {
        //constructor child class
        public VHS(string Title, string Category, double RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {

        }
        public double CurrentTime { get; set; }

        public override void Play()
        {
            //loop that will continue unless the user says "no" which will break the program. //need to learn more about this 
            while (true)
            {
                Console.WriteLine("Which scence do you want to play ? Please select between 0 to 5: ");
                //calling the Print scences method that will print the scene 
                PrintScenes();
                int sceneInput = int.Parse(Console.ReadLine());

                //here displaying the list based on user input. gotta do more research on this calling the list and then displaying the correct element into the scenes list
                Console.WriteLine("Scene " + sceneInput + " " + Scenes[sceneInput]);

                Console.WriteLine("Would you like to watch another scene ? y/n");
                string getUserInput = Console.ReadLine().ToLower();

                if (getUserInput == "n" || getUserInput == "no")
                {
                    break;
                }
            }
        }

        public void Rewind()
        {
            //couldn't figure out how to do this 

        }
    }
}
