using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharpOOP
{
    class Student : Person
    {

        public void Sleep()
        {
            EnergyLevel += 25;
            StressLevel -= 30;
        }

        public void DoHomework()
        {
            EnergyLevel -= 20;
            StressLevel += 25;
        }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            EnergyLevel = 100;
            StressLevel = 0;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - Stress:{StressLevel} Energy:{EnergyLevel}";
        }
    }
}
