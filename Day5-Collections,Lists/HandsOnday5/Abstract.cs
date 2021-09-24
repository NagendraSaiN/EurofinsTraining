using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnday5
{
    public abstract class Shape
    {
        public string color;
        public void SetColor(string C)
        {
            this.color = C;
        }
        public string GetColor()
        {
            return this.color;
        }
        public abstract double Area();
    }
    public class Rectangle : Shape
    {
        public int Length,Width;


        public Rectangle(int Length, int Width, string str)
        {
            SetColor(str);
            this.Length = Length;
            this.Width = Width;
        }

        public override double Area()
        {
            return this.Length * this.Width;
        }

        public void DisplayArea()
        {
            Console.WriteLine("Area of the Rectangle is : " + Area());
        }

    }
}

