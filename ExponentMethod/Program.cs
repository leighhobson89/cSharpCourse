using System;

namespace ExponentMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Raise to the power of: ");
            int power = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("The answer is: " + RaisePowerWithBuiltIn(num, power));
            Console.WriteLine("The answer is: " + RaisePowerWithForLoop(num, power));
            Console.WriteLine("The answer is: " + AlternateForLoop(num, power));
        }

        static double RaisePowerWithBuiltIn(double num, int power) // solution using built in System method
        {
            double result;

            result = Math.Pow(num, power);

            return result;
        }
        static double RaisePowerWithForLoop(double num, int power) // solution using for loop
        {
            double result;
            double baseNum = num; // init copy of original number to use as multiplier in loop

            for (int i = 1; i < power; i++)
            {
                num = num * baseNum; // multiply new value of num by the original value of itself [power] amount of times
            }
            result = num;
            return result;
        }
        static double AlternateForLoop(double num, int power) // solution using for loop
        {
            double result = 1; //init result as 1 so it can be multiplied by the user value entered

            for (int i = 0; i < power; i++)
            {
                result = result * num; // multiply new value of num by the original value of itself [power] amount of times and save in result variable
            }

            return result;
        }
    }
}
