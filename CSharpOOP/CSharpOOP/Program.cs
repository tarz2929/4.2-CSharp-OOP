using CSharpOOP.Shapes;
using System;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Drawing myDrawing = new Drawing();
            myDrawing.Draw(new Circle("Blue", 10));
            myDrawing.Draw(new Rectangle("Green", 10, 10));

            // Circle: Perimeter ~64, Area ~314
            // Rect: Perimeter 40, Area 100

            Console.WriteLine(myDrawing);
            Console.WriteLine(myDrawing.LinesDrawn);
            Console.WriteLine(myDrawing.SpaceCovered);
        }
    }
}
