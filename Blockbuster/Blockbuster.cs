using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    class Blockbuster
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public Blockbuster()
        {
            Movies.Add(new DVD("Saving Private Ryan", 300, Genre.Drama, "D-Day", "Saluting", "War stuff happens", "They find Matt Damon"));
            Movies.Add(new DVD("Lion King", 102, Genre.Drama, "I can't wait to be king", "Simba meets Timone and Pumba", "Simba and Nala fall in love", "Simba defeats Scar"));
            Movies.Add(new DVD("Billy Madison", 90, Genre.Comedy, "What are you looking at swan?", "Billy plays dodgeball", "Decatholon"));
            Movies.Add(new VHS("Aladdin", 90, Genre.Action, "Steals break", "Meets Jasmine", "Finds the magic lamp", "Defeats Jafar", "Frees the genie"));
            Movies.Add(new VHS("Dracula", 75, Genre.Horror, "Makes Renfield his servant", "Moves to London", "Turns people in vampires", "Van Helsing kills Dracula"));
            Movies.Add(new VHS("The Notebook", 124, Genre.Romance, "Main characters fall in love", "Things don't go well for them", "Guy writes in notebook", "They still love each other"));
            Movies.Add(new VHS("Zoolander", 89, Genre.Comedy, "Zoolander loses friends in freak gasoline fight incident", "He joints Mugatu's fashion show", "Mugatu brainwashes Derek to kill the Prime Minister of Malaysia", "Hansel helps Derek break out of the brainwashing"));


        }
        public void PrintMovies()
        {
            for(int i =0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];
                Console.WriteLine($"Index: {i}, {m.Title}");
            }
        }
        public Movie Checkout()
        {
            PrintMovies();
            Console.WriteLine("Which movie would you like to watch?");
            string input = Console.ReadLine();
            int index = int.Parse(input);
            Movie m = Movies[index];
            m.PrintInfo();
            return m;
        }
    }
}
