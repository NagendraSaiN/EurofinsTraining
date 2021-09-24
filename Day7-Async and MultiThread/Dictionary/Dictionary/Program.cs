using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> Game = new Dictionary<int, string>();
            Game.Add(1, "Player 5");
            Game.Add(2, "Player 1");
            Game.Add(3, "Player 3");
            Game.Add(4, "Player 2");
            Game.Add(5, "Player 4");
            Console.WriteLine("Total number of players are: " + Game.Keys.Count);

            foreach (KeyValuePair<int, string> k in Game)
                Console.WriteLine("Key: {0}, Value: {1}", k.Key, k.Value);

            Console.WriteLine();

            Console.WriteLine("New Results after the changes");
            Game[1] = "Player 4";
            Game[5] = "Player 5";

            foreach (KeyValuePair<int, string> g in Game)
                Console.WriteLine("Key: {0}, Value: {1}", g.Key, g.Value);

            Game.Clear();

            Console.Read();
        }
    }
}