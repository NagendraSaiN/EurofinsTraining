using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnday5
{
    class InterfaceAndPolyMorphism
    {
        public interface Shape
        {
            double Area();
            double Volume();
            
        }
        public class Cube : Shape
        {
            int x = 10;
            public double Area()
            {
                return 6 * x * x;
            }
            public double  Volume()
            {
                return x * x * x;
            }   
        }
        public class Circle: Shape
        {
            public int radius = 10;
            public double Area()
            {
                return radius * radius * 3.142;
            }
            public double Volume()
            {
                return 0;
            }    
        }
    }
}
