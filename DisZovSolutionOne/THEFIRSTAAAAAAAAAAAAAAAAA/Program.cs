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
            while(running)
            {
                Console.WriteLine("Would you like to run a calculation?");
                userInput = Console.ReadLine();
                userInput = userInput.ToLower();
                if (userInput.Equals("y") || userInput.Equals("yes"))
                {
                    Console.WriteLine("Well, too bad! That's not implemented!");
                }
                else
                {
                    running = false;
                }
            }
            Console.Read();
        }
    }
}
