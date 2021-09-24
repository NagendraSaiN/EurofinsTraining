using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace handsonday3
{
    class WritingFile
    {
        public void WriteFile()
        {
            FileStream fs = new FileStream(@"C:\Eurofins Training\Files\Temp3.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("File Created with contect name temp3.txt");
            sw.Close();
            fs.Close();

        }
        public void ReadFile()
        {
            FileStream fs = new FileStream(@"C:\Eurofins Training\Files\Temp4.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            fs.Close();
        }
        public void ParticularLine()
        {
            Console.WriteLine("Enter the number of line you need");
            int n = Convert.ToInt32(Console.ReadLine());
            FileStream fs = new FileStream(@"C:\Eurofins Training\Files\LineText.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            int i = 1;
            while(i<n)
            {
                string line = sr.ReadLine();
                i++;
            }
            Console.WriteLine("The Content of the Line in file LineText.txt is : " + sr.ReadLine());

        }
        public void LineCount()
        {
            FileStream fs = new FileStream(@"C:\Eurofins Training\Files\LineText.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            int i = 1;
            while(sr.Peek() > 0)
            {
                sr.ReadLine();
                i += 1;
            }
            Console.WriteLine("Number of lines in File are : " + i);

        }
    }
}
