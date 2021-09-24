using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Weight
    {
        int num;
        double w1,extra;
        public void input()
        {
            Console.WriteLine("Select the Class You booked");
            Console.WriteLine("Available Classes");
            Console.WriteLine("1.First Class");
            Console.WriteLine("2.Business Class");
            Console.WriteLine("3.Economy Class");
            num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1:
                    w1 = 50;
                    wei();
                    break;
                case 2:
                    w1 = 40;
                    wei();
                    break;
                case 3:
                    w1 = 20;
                    wei();
                    break;
                default:
                    Console.WriteLine("invalid option entered!!!!!");
                    break;
            }
        }
        public void wei()
        {
            Console.WriteLine("Maximum allowable weight is : " + w1);
            Console.WriteLine("Enter the weight of your baggage");
            double wgt = Convert.ToDouble(Console.ReadLine());
            if (wgt < (w1))
            {
                Console.WriteLine("Weight is under Allowable limit");
            }
            if (wgt > (w1))
            {
                Console.WriteLine("Over weight will be charged @ 2$/kg");
                Console.WriteLine("Weight is over than allowable limit!!!!!");
                extra = wgt - w1;
                Console.WriteLine("additional charged weight is:" + extra + " kg");
                extra = 2 * extra;
                Console.WriteLine("additional levied cost is (in $): " + extra + " $");
                Console.ReadKey();
            }

        }
    }
}
