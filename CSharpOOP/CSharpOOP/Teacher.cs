using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public Student[] Class { get; set; }

        public Classroom Room { get; set; }

        public void AssignHomework()
        {
            foreach (Student student in Class)
            {
                student.DoHomework();
            }
        }

        public Teacher(string firstName, string lastName, int numStudents, Classroom room)
        {
            FirstName = firstName;
            LastName = lastName;

            Class = new Student[numStudents];
            for (int i = 0; i < Class.Length; i++)
            {
                Class[i] = new Student("John", "Doe");
            }
            Room = room;
        }
    }
}
