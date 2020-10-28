using System;
using System.Collections.Generic;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty list.
            List<string> myStringList = new List<string>();

            // Initializer lists allow you to pre-populate lists when they are initialized.
            List<string> myInitializedList = new List<string>() { "Hello", "World", "Here", "Are", "Some", "Strings" };

            // Add things to a list.
            myStringList.Add("A String");

            // Remove things from a list by value or reference (depending on the type of data in the list).
            myInitializedList.Remove("Some");
            // "Hello", "World", "Here", "Are", "Strings"

            // Remove things from a list by index.
            myInitializedList.RemoveAt(3);
            // "Hello", "World", "Here", "Strings"

            // Number of things in a list.
            Console.WriteLine(myInitializedList.Count);
            // 4

            // Add multiple things to a list.
            myInitializedList.AddRange( new string[] { "Test", "Test", "Test", "Yes" } );
            // "Hello", "World", "Here", "Strings", "Test", "Test", "Test", "Yes"

            // Insert an item at a specific index.
            myInitializedList.Insert(5, "True");
            // "Hello", "World", "Here", "Strings", "Test", "True", "Test", "Test", "Yes"
            // InsertRange is a combination of this and AddRange.

            // Reverse the order of a list.
            myInitializedList.Reverse();
            // "Yes", "Test", "Test", "True", "Test", "Strings", "Here", "World", "Hello"

            // Remove all copies of the same thing from a list.
            myInitializedList.RemoveAll(x => x == "Test");
            // "Yes", "Strings", "Here", "World", "Hello"

            // Determine whether something is present.
            myInitializedList.Contains("Here");
            // true
            myInitializedList.Contains("False");
            // false

            // Sort a list.
            myInitializedList.Sort();
            // "Hello", "Here", "Strings", "World", "Yes"

            // Remove everything from a list.
            myInitializedList.Clear();

            
        }
    }
}
