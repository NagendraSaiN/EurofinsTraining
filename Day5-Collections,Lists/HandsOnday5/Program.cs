using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HandsOnday5
{
    class Program
    {
        static void Main(string[] args)
        {
            //First One
            //int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> Numbers = new List<int>(Num);
            //int x = SumOfEven.EvenSum(Numbers);
            //Console.WriteLine("Sum of Even Numbers is : " + x);
            //Console.ReadKey();


            //Second one
            string[] Words = { "Pandu", "Subbu", "Eurofins", "Training" };
            List<string> list1 = new List<string>(Words);
            Console.WriteLine("Enter the Word Length For Search of Words");
            int m = Convert.ToInt32(Console.ReadLine());
            StringsWith5Letters.Letters(list1, m);
            Console.ReadKey();

            //Third One
            //Rectangle rect = new Rectangle(5, 5, "RED");
            //rect.DisplayArea();
            //Console.ReadKey();


            //Fourth one Without Array 
            //InterfaceAndPolyMorphism.Cube cube = new InterfaceAndPolyMorphism.Cube();
            //Console.WriteLine("Length of side of Cube is 10 units");
            //Console.WriteLine("Area of  the Cube is = " + cube.Area());
            //Console.WriteLine("Volume of the Cube is = " + cube.Volume());


            //InterfaceAndPolyMorphism.Circle circle = new InterfaceAndPolyMorphism.Circle();
            //Console.WriteLine("Radius of Circle is 10 units ");
            //Console.WriteLine("Area of the Circle is = " + circle.Area());
            //Console.WriteLine("Volume of the Circle is = " + circle.Volume());
            //Console.ReadKey();

            //Fourth One With Array
            InterfaceAndPolyMorphism.Shape[] shapes = {new InterfaceAndPolyMorphism.Cube(),new InterfaceAndPolyMorphism.Circle() };
            for (int i = 0; i < shapes.Length; i++)
            {
                if(i == 0)
                {
                    Console.WriteLine("Area of cube: "+ shapes[i].Area());
                    Console.WriteLine("Volume of cube: "+ shapes[i].Volume());
                }
                if (i == 1)
                {
                    Console.WriteLine("Area of circle: " + shapes[i].Area());
                    Console.WriteLine("Volume of circle: " + shapes[i].Volume());
                }
                Console.ReadLine();
            }

        }
    }
}
