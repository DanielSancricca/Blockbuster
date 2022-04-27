using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    public enum Genre
    {
        Drama,
        Comedy,
        Horror,
        Romance,
        Action
    }
    public abstract class Movie
    {
        public string Title { get; set; }

        public Genre Category { get; set; }

        public int RunTime { get; set; }

        public List<string> Scenes { get; set; }

        public Movie(string Title, int RunTime, Genre Category, params string[] Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes.ToList();
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Category: " + Category);
            Console.WriteLine("RunTime: " + RunTime);
        }
        public void PrintScenes()
        {
            for(int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i}: {Scenes[i]}");
            }
        }
        public abstract void Play();
        

        

    }
    
}
