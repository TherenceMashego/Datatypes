using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables
            string name = "John";
            int age = 35;
            bool isTall = false;
            double weight = 80.2;

            // Display information about John
            Console.WriteLine($"{name} is {age} years old, and he weighs {weight}kg.");
            Console.WriteLine($"It is {isTall} that he is tall.");

            // Freeze console
            Console.ReadLine();
        }
    }
}

