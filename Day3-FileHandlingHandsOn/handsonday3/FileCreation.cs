using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace handsonday3
{
    class FileCreation
    {
        public string create()
        {
            FileStream fs = new FileStream(@"C:\Eurofins Training\Files\Temp3.txt", FileMode.Create);
            Console.WriteLine("File Created");
            return "File Created";

        }
    }
}
