using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: "); //take user value in to variables
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Choose an operation (+,-,*,/)");
            char whichOperator = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter another number ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Answer is " + CalculateAnswer(num1, num2, whichOperator)); //call CalculateAnswer method and pass in user values and output result
        }

        static string CalculateAnswer(double first, double second, char operation) //receive user values
        {
            string result; // initialise return variable

            if (operation == '+') //check user input and set return variable accordingly
            {
                result = Convert.ToString(first + second); // Calculate and convert to string the answer
            }
            else if (operation == '-')
            {
                result = Convert.ToString(first - second);
            }
            else if (operation == '*')
            {
                result = Convert.ToString(first * second);
            }
            else if (operation == '/')
            {
                result = Convert.ToString(first / second);
            }
            else
            {
                result = "Invalid value, sorry!";
            }
            
            return result;
        }
    }
}
