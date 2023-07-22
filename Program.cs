using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 2. Drawing a shape
            Console.WriteLine("    /|");
            Console.WriteLine("   / |");
            Console.WriteLine("  /  |");
            Console.WriteLine(" /   |");
            Console.WriteLine("/____|");

            // 3. Variables
            // Option 1 - Creating variable
            string characaterName = "John";
            // Option 2 - Declaring variable
            int characterAge;
            characterAge = 35;

            Console.WriteLine("Hello " + characaterName);
            Console.WriteLine("Happy " + characterAge + " Birthday!");

            characaterName = "Mike";
            Console.WriteLine("Did your name change in " + characaterName + "?");

            // 4. Data types
            string phrase = "Lion Academy";
            char grade = 'A';
            int age = 30;
            double gpa = 3.2;
            bool isMale = true;

            // 5. Strings
            // Newline
            Console.WriteLine("Lion \nAcademy");

            // Length of the String
            Console.WriteLine(phrase.Length);

            // Modifying the value of a string
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());

            // Finding if a string containes "Academy" - Returns a boolean
            Console.WriteLine(phrase.Contains("Academy"));

            // Select 1 element from a string
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("Academy")); // -1 if not in the string

            // Grab a part of a string
            Console.WriteLine(phrase.Substring(5, 4));

            // 6. Working with numbers
            Console.WriteLine((10 + 2) / 2 * 3);
            Console.WriteLine(5 % 2); // Rest

            int num = 6;
            num++; // add 1
            num--; // subtract 1
            Console.WriteLine(num);

            // Math method
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Sqrt(49));
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Min(4, 90));
            Console.WriteLine(Math.Round(4.6));

            // 7. Getting User Input
            Console.WriteLine( "Hello" );
            Console.Write("Enter your name: ");
            // Storing the user input into the "name" string
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            // Converting values
            int number = Convert.ToInt32("25");
            Console.WriteLine(number + Convert.ToInt32("36"));
            Console.WriteLine(number + Convert.ToDouble("25.4"));

            // 8. Building a calculator
            Console.Write("Enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            // 9. Building a Mad libs Game
            string colour, animal, place, action;

            Console.Write("Enter a color: ");
            colour = Console.ReadLine().ToLower();

            Console.Write("Enter an animal: ");
            animal =  Console.ReadLine().ToLower();

            Console.Write("Enter a place: ");
            place = Console.ReadLine();

            Console.Write("Enter an action: ");
            action = Console.ReadLine().ToLower();

            Console.WriteLine( $"Once upon a time, there was a {colour} {animal} who loved to {action} on the {place}.");
            Console.WriteLine($"One day, while {action}ing on the {place}, the {animal} found a magical treasure chest full of surprises!");
            
            // 10. Arrays

            // Keep Console open
            Console.ReadLine();
        }
    }
}
