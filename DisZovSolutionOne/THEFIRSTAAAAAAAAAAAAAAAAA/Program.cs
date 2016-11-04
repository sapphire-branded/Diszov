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
            while (running)
            {
                Console.WriteLine("Would you like to run a calculation?");
                Console.WriteLine("Available inputs: 'y', 'yes', 'ye'");
                userInput = Console.ReadLine();
                userInput = userInput.ToLower();
                if (userInput.Equals("y") || userInput.Equals("yes") || userInput.Equals("ye"))
                {
                    Console.WriteLine("What calculation would you like to run?");
                    Console.WriteLine("Available options: [+], [-], [x], [/]");
                    userInput = Console.ReadLine();
                    userInput = userInput.ToLower();
                    switch (userInput)
                    {
                        case "+":
                        case "[+]":
                            Console.WriteLine("Oh no, this isn't implemented yet! (ADD)");
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
