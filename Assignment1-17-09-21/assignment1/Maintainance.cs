using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class viewMaintainance
    {
        string user;
        int id;
        public void userid()
        {
            Console.WriteLine("Enter your personal user name : ");
            user = Console.ReadLine();
            if (user == "nagendra" || user == "Sai" || user == "EITS2204")
            {
                example();
            }

            else
            {
                Console.WriteLine("Please enter a valid user Name!!!!!!");
            }
            Console.ReadKey();
        }
        public void example()
        {
            Console.WriteLine("Enter the vaild Aircraft ID:");
            id = Convert.ToInt32(Console.ReadLine());
            switch (id)
            {
                case 1:
                    Console.WriteLine("aircraft is under maintainance for 1 days!");
                    break;
                case 2:
                    Console.WriteLine("aircraft is under maintainance for 2 days!");
                    break;
                case 3:
                    Console.WriteLine("aircraft is under maintainance for 3 days!");
                    break;
                case 4:
                    Console.WriteLine("aircraft is under maintainance for 4 days!");
                    break;
                default:
                    Console.WriteLine("Aircraft ID does not Exist or Server Down!!!!!!!");
                    break;
            }
        }
    }
}
