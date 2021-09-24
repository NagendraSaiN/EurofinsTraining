using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileLibrary;

namespace FirstConsoleAppDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileServices mobileServices = new MobileServices();
            mobileServices.ServiceTypes();
            Mobile objmobile = new Mobile();
            objmobile.MobileModels("");
            Console.Read();
        }
    }
}
