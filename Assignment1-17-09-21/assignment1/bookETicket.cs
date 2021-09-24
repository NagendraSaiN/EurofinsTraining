using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class bookETicket
    {
        string name, mail, age, to , from, date;

        public void details()
        {
            Console.WriteLine("Enter Your Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Your Mail ID :");
            mail = Console.ReadLine();
            Console.WriteLine("Enter Your Age :");
            age = Console.ReadLine();
            Console.WriteLine("Enter Your destination :");
            to = Console.ReadLine();
            Console.WriteLine("Enter from Airport or City :");
            from = Console.ReadLine();
            Console.WriteLine("Enter Date in dd/mm/yyyy :");
            date = Console.ReadLine();
        }
    }
    class ebook : bookETicket

    {
        int num;
        public void ebookf()
        {
            Console.WriteLine("Enter the number of passenger who want(s) to travel :");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.Clear();
                Console.WriteLine("Enter the detail of " + i + " passenger :");
                details();

            }
        }
    }
}
