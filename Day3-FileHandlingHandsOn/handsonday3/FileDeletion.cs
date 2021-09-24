using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace handsonday3
{
    class FileDeletion
    {
        public void delete()
        {
            File.Delete(@"C:\Eurofins Training\Files\Temp3.txt");
            Console.WriteLine("File Deleted");
        }
    }
}
