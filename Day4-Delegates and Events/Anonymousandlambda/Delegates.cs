using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Program
    {
        //NonStatic method
        public void Add(int x, int y)
        {
            Console.WriteLine("Using Nonstatic method");
            Console.WriteLine(@"The Sum of {0} and {1}  : {2}", x, y, (x + y));
        }

        //Static Method
        public static string Greetings(string name)
        {
            Console.WriteLine("\nUsing Static method");
            return "Hello @" + name;
        }
    }
}
