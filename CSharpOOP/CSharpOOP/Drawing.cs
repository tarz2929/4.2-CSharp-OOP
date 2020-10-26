using CSharpOOP.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    class Drawing
    {
        /*
         Properties:
            ✅ “Shapes” (private getter and setter)
                ✅ Polymorphic list of “Shape”.
            ✅ “SpaceCovered” (public getter only)
                Total area of the contents of “Shapes”.
            ✅ “LinesDrawn” (public getter only).
                The total perimeter/circumference of the contents of “Shapes”.
        Methods:
            ✅ “Draw(Shape)” 
                ✅ Accepts a polymorphic “Shape” argument and adds it to the “Shapes” list.
            ✅ A ToString() override, which will output “A drawing consisting of X shapes.” where X is the number of items in “Shapes”.
            ✅ A default constructor that will initialize “Shapes”.
        */

        private List<Shape> Shapes { get; set; }

        public double SpaceCovered 
        { 
            get 
            {
                double total = 0;
                foreach (Shape shape in Shapes)
                {
                    total += shape.Area;
                }
                return total;
            } 
        }

        public double LinesDrawn
        {
            get
            {
                double total = 0;
                foreach (Shape shape in Shapes)
                {
                    total += shape.Perimeter;
                }
                return total;
            }
        }

        public void Draw(Shape shape)
        {
            Shapes.Add(shape);
        }

        public override string ToString()
        {
            return $"A drawing consisting of {Shapes.Count} shapes.";
        }

        public Drawing()
        {
            Shapes = new List<Shape>();
        }
    }
}
