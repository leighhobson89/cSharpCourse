using System;

namespace VariablesAndConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants
            //used to add safety.  this value is always fixed so cannot be used as a variable in the program at any point

            const float Pi = 3.14f; //added 'f' to end so no intepreted as a 'double'

            //variables
            byte number = 2; //define byte variable type
            int count = 10; //define int variable type
            float totalPrice = 20.95f; //define float variable type (need to add 'f' to end otherwise interpreted by compiler as a 'double')
            char character = 'A'; //define character variable type
            string firstName = "Leigh"; //define string variable type
            bool isWorking = true; //define boolean variable type

            Console.WriteLine(number); //write out variables
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking); //---------------------

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); //format string print out min and max values of byte datatype
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue); //format string print out min and max values of float datatype

        }
    }
}
