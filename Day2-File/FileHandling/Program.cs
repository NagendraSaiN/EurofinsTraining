using System;

namespace Myfirstconsoleapp
{
    class Program
    {
        
        static void Main(string[] args)
        {




            filehandling objfile = new filehandling();
            Console.WriteLine("WriteFile : " + objfile.WriteFile());
            Console.WriteLine(objfile.ReadFile());

        }
    }
}
