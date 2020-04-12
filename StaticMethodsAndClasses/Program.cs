using System;

namespace StaticMethodsAndClasses //static method belongs to class, doesn't need an object to be used
{
    class Program
    {
        static void Main(string[] args)
        {
            // Math myMath = new Math(); // normal way to create object and call method is not necessary if the method is a static method as below:
            Console.WriteLine(Math.Sqrt(144)); //Sqrt method is a static method of the Math class so can be called anytime without an object being necessary
            UsefulTools.SayHi("Leigh"); //calls static method in UsefulTools class
        }
    }
}
