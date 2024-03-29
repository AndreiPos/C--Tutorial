using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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

            // Finding if a string contains "Academy" - Returns a boolean
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
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            string[] friends = new string[10];
            friends[0] = "Tarick";
            friends[1] = "Janna";

            luckyNumbers[2] = 100;
            Console.WriteLine(luckyNumbers[2]);

            // 11. Methods
            SayHi("Mike", 23);

            // 12. Return Statement
            int cubedNumber = Cube(3);
            Console.WriteLine(cubedNumber);

            // 13. If statements
            bool isFemale = true;
            bool isTall = true;

            if (isFemale && isTall)
            {
                Console.WriteLine("You are a tall female.");
            } 
            else if (isFemale && !isTall)
            {
                Console.WriteLine("You are a short female.");
            }
            else if (!isFemale && isTall)
            {
                Console.WriteLine("You are not a female but you are all.");
            }
            else
            {
                Console.WriteLine("You are not female and not tall.");
            }


            Console.WriteLine(GetMax(2, 10, 6));

            // 14. Switch statements
            Console.WriteLine(GetDay(2));

            // 15. While loops
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            int index2 = 6;
            do
            {
                Console.WriteLine(index2);
                index2++;
            } while (index <= 5);

            // 16. Building a Guessing game
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 5;
            bool outOfGuesses = false;

            while(guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.Write("You Lose!");
            }
            else
            {
                Console.Write("You Win!");
            }

            // 17. For loops
            int j = 1;
            while (j <=5)
            {
                Console.WriteLine(j);
                j++;
            }

            int[] luckyNr = { 4, 8, 15, 16, 28, 48 };
            for (int i = 1; i < luckyNr.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            // 18. Exponent method
            Console.WriteLine(GetPow(3, 2));

            // 19. 2D arrays
            int[,] numberGrid =
            {
                {1, 2 },
                {3, 4 },
                {5, 6 },
            };
            Console.WriteLine(numberGrid[2, 1]);

            // 20. Exception handling
            try
            {
                Console.Write("Enter a number: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(number1 / number2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            // 21. Classes and Objects 
            /*
            Book book1 = new Book();
            book1.title = "The Lord of the Rings";
            book1.author = "Tolkein";
            book1.pages = 1178;
            */

            // 22. Constructors
            Book book2 = new Book("Harry Potter", "JK Rowling", 317);

            Console.WriteLine(book2.title);

            // 23. Object Methods
            Student student1 = new Student("Jim", "Business", 58.8);
            Student student2 = new Student("Pam", "Art", 79.3);

            Console.WriteLine(student1.HasHonours());
            Console.WriteLine(student2.HasHonours());

            // 24. Getters and Setters
            Movie avengers = new Movie("The Avengers", "John Whedon", "PG-13");
            Movie shrek = new Movie("Shreck", "Adam Adamson", "PG");

            Console.WriteLine(avengers.Rating);

            // 25. Static Class Attributes
            Song holiday = new Song("Holiday", "Green Day", 233);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 581);
            Console.WriteLine(holiday.getSongCount());

            Console.WriteLine(kashmir.artist);

            // 26. Static Methods and Classes
            UsefulTools.SayHi("Jake");

            // 27. Inheritance
            // Superclass
            Chef chef = new Chef();
            chef.MakeChicken();

            // Subclass
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakePasta();

            // Keep Console open
            Console.ReadLine();
        }

        // 11. Methods
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        // 12. Return Statement
        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }

        // 13. If statements
        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >=num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        }

        // 14. Switch statements
        static string GetDay(int dayNum)
        {
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Moday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }
            return dayName;
        }

        // 18. Exponent method
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;
            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }
            return result;
        }
    }
}
