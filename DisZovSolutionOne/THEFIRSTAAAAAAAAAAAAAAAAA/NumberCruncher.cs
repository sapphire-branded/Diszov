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

        public double add(double[] numbers)
        {
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
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
            return System.Math.Pow(num1, 2);
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

        public double[] getNumbers(int numOfNumbers)
        {
            double[] numbers = new double[numOfNumbers];
            for (int i =0; i < numOfNumbers; i++)
            {
                numbers[i] = getNumber();
            }
            return numbers;
        }

        public int getNumOfNumbers(int min)
        {
            bool invalidInput;
            int num1;
            string userInput = "";
            do
            {
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out num1))
                {
                    if(num1 >= min)
                    {
                        Console.WriteLine("The chosen number is: " + num1);
                        invalidInput = false;
                    }
                    else
                    {
                        Console.WriteLine("The chosen number is too low! Please enter a number higher than " + min);
                        invalidInput = true;
                        Console.WriteLine("Please enter the number of numbers you wish to perform calculations on: ");
                    }                    
                }
                else
                {
                    Console.WriteLine("Error, please only input numbers!");
                    invalidInput = true;
                    Console.WriteLine("Please enter the number of numbers you wish to perform calculations on: ");
                }
            } while (invalidInput);
            return num1;
        }

        public string getCalculationString(double[] inputs, double result, string operation)
        {
            string calcString = "";
            for (int i = 0; i < inputs.Length; i++)
            {
                calcString = calcString + inputs[i] + " " + operation + " ";
            }
            calcString = calcString + "is " + result + ".\n";
            return calcString;
        }

        public string getCalculationString(double[] inputs, double[] results, string operation)
        {
            string calcString = "";
            for (int i = 0; i < results.Length; i++)
            {
                calcString = calcString + inputs[i] + " " + operation + " is " + results[i] + ".\n";
            }
            return calcString;
        }

        public int getNumberBetween(int min, int max)
        {
            Random r = new Random();
            int rInt = r.Next(min, max); //for ints
            return rInt;
        }

        public int[] getNumbersBetween(int min, int max, int numOfNumbers)
        {
            Random r = new Random();
            int[] rInt = new int[numOfNumbers];
            for (int i = 0; i < numOfNumbers; i++)
            {
                rInt[i] = r.Next(min, max);
            }
            return rInt;
        }

        public double getNumberBetween(double min, double max)
        {
            Random r = new Random();
            double range = max - min;
            double rDouble = ((r.NextDouble() * range) + min);
            return rDouble;
        }

        public double[] getNumbersBetween(double min, double max, int numOfNumbers)
        {
            Random r = new Random();
            double range = max - min;
            double[] rDouble = new double[numOfNumbers];
            for (int i = 0; i < numOfNumbers; i++)
            {
                rDouble[i] = ((r.NextDouble() * range) + min);
            }
            return rDouble;
        }
    }
}
