using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnday5
{
    class StringsWith5Letters
    {
        public static void Letters(List<String> k, int n)
        {
            for (int i = 0; i < k.Count; i++)
            {
                if (k[i].Length == n)
                {
                    Console.WriteLine(k[i]);
                }
            }
            
        }
    }
}
