using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try //tells c# to attempt to run code.  if any exceptions occur, run the code in the 'catch' block below
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (Exception e) //defines which errors are caught, in this case all
            {
                Console.WriteLine(e.Message); // prints out the error message from the exceptions library
            }
            /*catch (DivideByZeroException e) // in this case only DivideByZeroException is caught, any others would show a normal exception and break the program - could use "FormatException" to catch incorrect value being entered for example or many more
            {
                Console.WriteLine(e.Message); // can display a custom message or the standard one by putting it here
            }*/

            finally //code here is always run when an exception is thrown
            {
                Console.WriteLine("We're still alive!!");
            }

            Console.ReadLine();

        }
    }
}
