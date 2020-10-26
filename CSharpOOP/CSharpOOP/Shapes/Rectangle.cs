using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP.Shapes
{
    class Rectangle : Shape
    {
        /*
         Properties:
            ✅ “Length”
            ✅ “Width”
        */

        public override double Perimeter
        { 
            get
            {
                return (Length + Width) * 2;
            }
        }

        public override double Area
        {
            get
            {
                return Length * Width;
            }
        }

        public double Length { get; set; }

        public double Width { get; set; }

        public Rectangle() : base()
        {
            Length = 20;
            Width = 10;
        }

        public Rectangle(string colour, double length, double width) : base(colour)
        {
            Length = length;
            Width = width;
        }
    }
}
