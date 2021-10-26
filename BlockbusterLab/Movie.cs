using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    abstract class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; } 
        public double RunTime { get; set; }

        //List of strings for the movie scenes
        public List<string> Scenes = new List<string>();

        public Movie(string Title, string Category, double RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }

        // we could try using of Enum Genre but Tommy said since we have not covered it we could jst use a TO string
        public virtual string ToString()
        {
            string output = $"Title: {Title}\n";
            output += $"Category: { Category}\n";
            output += $"Runtime: {RunTime}\n";
            

            return output;
        }

        public void PrintScenes()
        {
            foreach(string scene in Scenes)
            {
                //this loop
                Console.WriteLine(Scenes.IndexOf(scene) + ": " + scene);
            }
        }

        //virtual method with no return type
        public abstract void Play();
    }
}
