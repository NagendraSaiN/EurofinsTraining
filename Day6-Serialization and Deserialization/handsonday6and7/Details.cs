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
    [Serializable]

public class Details
    {
        public string name;
        public int age;
        private City city;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public void person()
        {
            Details p = new Details();
            p.name = "Nagendra";
            p.age = 21;
            p.city = new City();
            p.city.City_name = "Bangalore";
            p.city.City_population = 250000;

            var formatter = new BinaryFormatter();
            FileStream fs = new FileStream(@"C:\Eurofins Training\Day6\Person.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(fs, p);
            fs.Close();
        }
        public void deserialize()
        {
            var formatter = new BinaryFormatter();
            FileStream fs = new FileStream(@"C:\Eurofins Training\Day6\Person.txt", FileMode.OpenOrCreate, FileAccess.Read);
            var pp = (Details)formatter.Deserialize(fs);
            Console.WriteLine(pp.name);
            Console.WriteLine(pp.age);
            Console.WriteLine(pp.city.city_name);
            Console.WriteLine(pp.city.city_population);
            fs.Close();
        }
        public void serializexml()
        {
            Details p = new Details();
            p.name = "Nagendra";
            p.age = 21;
            p.city = new City();
            p.city.City_name = "Bangalore";
            p.city.City_population = 250000;
            XmlSerializer xs = new XmlSerializer(typeof(Details));
            FileStream fs = new FileStream(@"C:\Eurofins Training\Day6\PersonXML.xml", FileMode.Create, FileAccess.Write);
            xs.Serialize(fs, p);
            fs.Close();
        }
        public void deserializexml()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Details));
            FileStream fs = new FileStream(@"C:\Eurofins Training\Day6\PersonXML.xml", FileMode.Open, FileAccess.Read);
            var ss = (Details)xs.Deserialize(fs);
            Console.WriteLine(ss.name);
            Console.WriteLine(ss.age);
            //Console.WriteLine(ss.city.city_name);
            //Console.WriteLine(ss.city.city_population);
;

        }
    }
}
