using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;

namespace SerializeandDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Details d = new Details();
            d.person();
            d.deserialize();
            d.serializexml();
            d.deserializexml();
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
