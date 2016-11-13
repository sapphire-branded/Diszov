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
                    Console.WriteLine("What calculation would you like to run?");
                    Console.WriteLine("Available options: [+], [-], [x], [/], [^], [r]");
                    userInput = Console.ReadLine();
                    userInput = userInput.ToLower();
                    double num1, num2;          
                    switch (userInput)
                    {
                        case "+":
                        case "[+]":
                            Console.WriteLine("Please input the number of numbers you wish to add");
                            int numOfNumbers = cruncher.getNumOfNumbers(2);
                            double[] numbers = cruncher.getNumbers(numOfNumbers);
                            double result = cruncher.add(numbers);
                            Console.WriteLine(cruncher.getCalculationString(numbers, result, "plus"));
                            break;
                        case "-":
                        case "[-]":
                            Console.WriteLine("Please input the first number");
                            num1 = cruncher.getNumber();
                            Console.WriteLine("Please input the second number");
                            num2 = cruncher.getNumber();
                            Console.WriteLine(num1 + " minus " + num2 + " is: " + cruncher.minus(num1, num2));
                            break;
                        case "x":
                        case "[x]":
                            Console.WriteLine("Please input the first number");
                            num1 = cruncher.getNumber();
                            Console.WriteLine("Please input the second number");
                            num2 = cruncher.getNumber();
                            Console.WriteLine(num1 + " multiplied by " + num2 + " is: " + cruncher.mult(num1, num2));
                            break;
                        case "/":
                        case "[/]":
                            Console.WriteLine("Please input the first number");
                            num1 = cruncher.getNumber();
                            Console.WriteLine("Please input the second number");
                            num2 = cruncher.getNumber();
                            Console.WriteLine(num1 + " divided by " + num2 + " is: " + cruncher.div(num1, num2));
                            break;
                        case "^":
                        case "[^]":
                            num1 = cruncher.getNumber();
                            Console.WriteLine(num1 + " squared is: " + cruncher.square(num1));
                            break;
                        case "r":
                        case "[r]":
                        case "R":
                        case "[R]":
                            num1 = cruncher.getNumber();
                            Console.WriteLine("The square root of " + num1 + " is: " + cruncher.squareRoot(num1));
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
