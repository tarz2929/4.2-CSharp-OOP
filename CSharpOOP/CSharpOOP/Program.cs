using System;
using System.Collections.Generic;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Student theStudent = new Student("Test", "McTest");
            Classroom theRoom = new Classroom(101);

            // Static method example.
            Student.Sleep();

            Teacher theTeacher = new Teacher("Teacher", "McTest", theRoom);

            //List<Student> someStudents = new List<Student>();
            theTeacher.Class[0] = theStudent;

            //someStudents[0].DoHomework();
            theTeacher.Class[0].DoHomework();

            theStudent.EnergyLevel = 100000;
            //theRoom.RoomNumber
            //theTeacher.Room.RoomNumber



        }


    }
}
