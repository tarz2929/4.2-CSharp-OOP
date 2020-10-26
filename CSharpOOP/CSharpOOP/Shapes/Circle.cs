using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP.Shapes
{
    // Pillar: Inheritance
    class Circle : Shape
    {
        /*
         “Perimeter” is equivalent to a circumference for “Circle”.
        Properties:
            ✅ “Radius”
            ✅ “Diameter”
                ✅ Public getter that derives its value from “Radius”.

        */
        public override double Perimeter
        {
            get
            {
                return Math.PI * Diameter;
            }
        }

        public override double Area
        {
            get
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        public double Radius { get; set; }

        public double Diameter { 
            get
            {
                return Radius * 2;
            }
        }

        public Circle() : base()
        {
            Radius = 20;
        }

        public Circle(string colour, double radius) : base(colour)
        {
            Radius = radius;
        }
    }
}
