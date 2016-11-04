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

                    if (userInput.Equals("+") || userInput.Equals("[+]"))
                    {
                        Console.WriteLine("Oh no, this isn't implemented yet! (ADD)");
                    }
                    if (userInput.Equals("-") || userInput.Equals("[-]"))
                    {
                        Console.WriteLine("Oh no, this isn't implemented yet! (SUB)");
                    }
                    else
                    {
                        string caseSwitch = userInput;
                        switch (caseSwitch)
                        {
                            case "x":
                            case "[x]":
                                caseSwitch = "x";
                                Console.WriteLine("Oh no, this isn't implemented yet! (MULT)");
                                userInput = Console.ReadLine();
                                running = false;
                                break;
                            case "/":
                            case "[/]":
                                caseSwitch = "/";
                                Console.WriteLine("Oh no, this isn't implemented yet! (DIVI)");
                                userInput = Console.ReadLine();
                                running = false;
                                break;
                            default:
                                running = false;
                                break;
                        }
                    }
                }
            }
            Console.Read();
        }
    }
}
