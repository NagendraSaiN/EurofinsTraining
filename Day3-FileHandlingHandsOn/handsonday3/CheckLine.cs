using System;
using System.Collections.Generic;
using System.Text;

namespace handsonday3
{
    class CheckLine
    {
        public void Line()
        {
            int n,m;
            
            Console.WriteLine("Enter the Number of lines you want to enter");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] vs= { "" };
                Console.WriteLine("Enter the Input");
                vs[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the line number you need");
            m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i==m)
                {
                    object vs = null;
                    //Console.WriteLine(vs[i]);

                }

            }
            

        }
    }
}
