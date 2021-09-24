using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeandDeserialize
{
    [Serializable]
    class City
    {
        public string city_name;
        public int city_population;

        public string City_name { get => city_name; set => city_name = value; }
        public int City_population { get => city_population; set => city_population = value; }
    }
}
