using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileLibrary
{
    public class Mobile
    {
        public void MobileTypes()
        {
            Console.WriteLine("Mobile Types");
            Console.WriteLine("Android");
            Console.WriteLine("IOS");
        }
        public void MobileModels(string MobileTypes)
        {
            if(MobileTypes == "IOS")
            {
                Console.WriteLine("Apple");
            }
        }
    }
}
