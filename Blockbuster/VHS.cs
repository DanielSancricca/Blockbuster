using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    public class VHS : Movie
    {
        public int CurrentScene { get; set; }

        public VHS(string Title, int RunTime, Genre Category, params string[] Scenes)
            : base(Title, RunTime, Category, Scenes)
        {

        }

        public override void Play()
        {
            int i;
            for (i=CurrentScene; i <= Scenes.Count; i++)
            {
                CurrentScene = i;
                Console.WriteLine(Scenes[i]);
            }
        }
        public void Rewind()
        {
            CurrentScene = 0;
        }
    }
}
