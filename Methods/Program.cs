using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Mike", 33); //call method and pass in name and age parameter to process
            SayHi("John", 12);
            SayHi("Tom", 56);

            int cubedNumber = Cube(12); // call cubing method and pass in number to process, and write result in integer variable cubedNumber
            Console.WriteLine(Cube(cubedNumber)); // call cubing method and pass in variable cubedNumber to process, and output result to console
        }
        // create methods outside the Main() method
        // code outside Main() method wont be run unless it is called
        // method name with Capital letter (arguments)

        // static - if outside Main Method
        // void - methods not going to return any value
        // int - method will be returning an integer

        static void SayHi(string name, int age) // datatype set to void to show we are not returning any values to the caller (and expecting a string and an integer parameter to be passed in)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        // method to cube a number ie 2 * 2 * 2 = 8

        static int Cube(int num) // datatype set to int to show we will be returning an integer value (and expecting an integer to be passed in)
        {
            int result = num * num * num; // cubing maths
            return result;
        }

    }
}
