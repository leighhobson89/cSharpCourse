using System;

namespace Comparisons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(2, 10)); //pass two different integers and write out largest one
            Console.WriteLine(GetMaxy(18, 16, 15)); //pass three different integers and write out largest one
        }


        static int GetMax(int num1, int num2) //compare 2
        {
            int result;

            if (num1 > num2) //check which is bigger
            {
                result = num1; //if num1 > num2 set return variable to num1 
            }
            else
            {
                result = num2; // else set it to num2
            }

            return result; //return which is bigger
        }
        static int GetMaxy(int num1, int num2, int num3) //compare 3
        {
            int result;

            if (num1 > num2 && num1 > num3) //check if num1 is biggest
            {
                result = num1; // and set num1 as return variable
            }
            else if (num2 > num1 && num2 > num3) //check if num2 is biggest
            {
                result = num2; // and set num2 as return variable
            }
            else
            {
                result = num3; // otherwise set num3 as return variable
            }

            return result; //return which is bigger
        }
    }
}
