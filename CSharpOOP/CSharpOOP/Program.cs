using System;
using System.Collections.Generic;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------
            // Lists
            // ----------

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

            // ----------
            // Stacks & Queues
            // ----------

            // Stacks: Last In, First Out
            Stack<int> myIntStack = new Stack<int>();

            // Push = Add
            myIntStack.Push(12);
            myIntStack.Push(42);
            myIntStack.Push(3);
            // 12, 42, 3

            // Pop = "Grab The Top Thing"
            Console.WriteLine(myIntStack.Pop());
            // 3
            // Note that Pop() removes the item from the stack.
            // If you just want to get it without removing it, use Peek().
            Console.WriteLine(myIntStack.Peek());
            // 42


            // Queues: First In, First Out
            Queue<int> myIntQueue = new Queue<int>();

            // Enqueue = Add
            myIntQueue.Enqueue(8);
            myIntQueue.Enqueue(42);
            myIntQueue.Enqueue(7);
            // 8, 42, 7

            // Dequeue = Pop() but from the "front" instead of the "top".
            Console.WriteLine(myIntQueue.Dequeue());
            // 8
            // Peek works the same way with Queues as Stacks, view the next thing to be dequeued without removing it.
            Console.WriteLine(myIntQueue.Peek());
            // 42

            // ----------
            // Dictionaries
            // ----------

            // Normal lists are indexed by ints (starting at 0, then 1, etc).
            // Dictionaries can be indexed by anything.
            Dictionary<char, int> characterCounts = new Dictionary<char, int>();

            string example = "The quick brown fox jumps over the lazy dog.";

            foreach (char character in example)
            {
                // If the key doesn't exist, add it with a 0.
                if (!characterCounts.ContainsKey(char.ToUpper(character)))
                {
                    characterCounts.Add(char.ToUpper(character), 0);
                }
                // Increment the value associated with the character.
                characterCounts[char.ToUpper(character)] += 1;
            }

            Console.WriteLine($"There are {characterCounts['o']} O's in the string.");


        }
    }
}
