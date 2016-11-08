using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THEFIRSTAAAAAAAAAAAAAAAAA
{
    class NumberCruncher
    {
        public NumberCruncher(){}

        public double add(double num1, double num2)
        {
            return (num1 + num2);
        }

        public double minus(double num1, double num2)
        {
            return (num1 - num2);
        }

        public double mult(double num1, double num2)
        {
            return (num1 * num2);
        }

        public double div(double num1, double num2)
        {
            return (num1 / num2);
        }

        public double square(double num1)
        {
            return System.Math.Pow(num1, num1);
        }

        public double squareRoot(double num1)
        {
            return System.Math.Sqrt(num1);
        }

        public double getNumber()
        {
            bool invalidInput;
            double num1;
            string userInput = "";
            do
            {
                Console.WriteLine("Please enter the desired number: ");
                userInput = Console.ReadLine();
                if (double.TryParse(userInput, out num1))
                {
                    Console.WriteLine("The chosen number is: " + num1);
                    invalidInput = false;
                }
                else
                {
                    Console.WriteLine("Error, please only input numbers!");
                    invalidInput = true;
                }
            } while (invalidInput);
            return num1;
        }
    }
}
