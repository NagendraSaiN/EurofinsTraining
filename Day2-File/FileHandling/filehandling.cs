using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Myfirstconsoleapp
{
    class filehandling
    {
        public string WriteFile()
        {
            //int n, regno;
            //string course_name, course_title;
            //FileStream fs = new FileStream(@"C:\Eurofins Training\Files\Temp.txt", FileMode.OpenOrCreate, FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine("File:");
            //sw.WriteLine("Course Details");
            //sw.WriteLine("**************");
            //Console.WriteLine("Enter the number of Courses");
            //n = Convert.ToInt32(Console.ReadLine());
            //sw.WriteLine(n);
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Enter the register number of Course");
            //    regno = Convert.ToInt32(Console.ReadLine());
            //    sw.WriteLine("Register number : " + regno);
            //    Console.WriteLine("Enter the Name of the Course");
            //    course_name = Console.ReadLine();
            //    sw.WriteLine("Course name : " + course_name);
            //    Console.WriteLine("Enter the Title of the Course");
            //    course_title = Console.ReadLine();
            //    sw.WriteLine("Course title : " + course_title);
            //}
            //sw.Close();
            //fs.Close();
            return "File Created";
        }

        public int ReadFile()
        {

            FileStream fs = new FileStream(@"C:\Eurofins Training\Files\Temp2.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("Mobile Network Performance");
            Console.WriteLine("**************************");
            Console.Write("Source         Destination         Date               Call Status");
            Console.WriteLine("");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains(":"))
                {
                    string[] details = line.Split(":");
                    Console.Write(details[1]+"       ");
                }
                else {
                    Console.WriteLine("");
                }
                    
             
            }
            sr.Close();
            fs.Close();

            return 1;
        }
    }
}
