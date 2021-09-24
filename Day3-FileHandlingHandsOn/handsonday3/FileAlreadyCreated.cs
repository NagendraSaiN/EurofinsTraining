using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace handsonday3
{
    class FileAlreadyCreated
    {
        public void exist()
        {
            try
            {
                FileStream fr = new FileStream(@"C:\Eurofins Training\Files\Temp3.txt", FileMode.CreateNew);

            }
            catch (IOException)
            {
                Console.WriteLine("File Already Created with name temp3.txt");
            }
            Console.ReadKey();
        }
    }
}
