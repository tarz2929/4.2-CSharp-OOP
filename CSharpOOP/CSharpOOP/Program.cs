using System;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher mathTeacher = new Teacher("Bob", "Jones", 10, new Classroom(101));

            Student joe = new Student("Joe", "Smith");
            Student sally = new Student("Sally", "Howard");



            Console.WriteLine(joe);
            Console.WriteLine(sally);

            mathTeacher.AssignHomework();

            string joesState = joe.ToString();

            Console.WriteLine(joe);
            Console.WriteLine(sally);

            joe.Sleep();
            joe.Sleep();
            joe.Sleep();
            Console.WriteLine(joe);

        }

        public void WriteMenu()
        {
            Console.WriteLine("Option 1");
            Console.WriteLine("Option 2");
            Console.WriteLine("Option 3");
            Console.WriteLine("Option 4");
        }
    }
}
