using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THEFIRSTAAAAAAAAAAAAAAAAA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Disva and Zovael's Calculator!");
            Console.WriteLine("Please make all deposits in rear~");
            bool running = true;
            String userInput = "";
            NumberCruncher cruncher = new NumberCruncher();
            while (running)
            {
                Console.WriteLine("Would you like to run a calculation?");
                Console.WriteLine("Available inputs: 'y', 'yes', 'ye'");
                userInput = Console.ReadLine();
                userInput = userInput.ToLower();
                if (userInput.Equals("y") || userInput.Equals("yes") || userInput.Equals("ye"))
                {
                    bool invalidInput;
                    double num1, num2;
                    do
                    {
                        Console.WriteLine("Please enter the first number: ");
                        userInput = Console.ReadLine();
                        if (double.TryParse(userInput, out num1))
                        {
                            Console.WriteLine("The first number is: " + num1);
                            invalidInput = false;
                        }
                        else
                        {
                            Console.WriteLine("Error, please only input numbers!");
                            invalidInput = true;
                        }
                    } while (invalidInput);

                    do
                    {
                        Console.WriteLine("Please enter the second number: ");
                        userInput = Console.ReadLine();
                        if (double.TryParse(userInput, out num2))
                        {
                            Console.WriteLine("The second number is: " + num2);
                            invalidInput = false;
                        }
                        else
                        {
                            Console.WriteLine("Error, please only input numbers!");
                            invalidInput = true;
                        }
                    } while (invalidInput);
                    Console.WriteLine("What calculation would you like to run?");
                    Console.WriteLine("Available options: [+], [-], [x], [/]");
                    userInput = Console.ReadLine();
                    userInput = userInput.ToLower();                    
                    switch (userInput)
                    {
                        case "+":
                        case "[+]":
                            Console.WriteLine(num1 + " plus " + num2 + " is: " + cruncher.add(num1, num2));
                            break;
                        case "-":
                        case "[-]":
                            Console.WriteLine("Oh no, this isn't implemented yet! (SUB)");
                            break;
                        case "x":
                        case "[x]":
                            Console.WriteLine("Oh no, this isn't implemented yet! (MULT)");
                            break;
                        case "/":
                        case "[/]":
                            Console.WriteLine("Oh no, this isn't implemented yet! (DIVI)");
                            break;
                        default:
                            Console.WriteLine(userInput + " is not an accepted command!");
                            break;
                    }
                }
                else
                    running = false;
            }
            Console.Read();
        }
    }
}
