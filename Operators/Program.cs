using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10; //define two variables with '=' operator and use '+' to add them
            var b = 3;

            Console.WriteLine(a + b); //13

            var c = 10; //define two variables with '=' operator and use '/' to divide them (use float casting to get more precise decimal result otherwise integer is written)
            var d = 3;

            Console.WriteLine((float)c / (float)d); //3.333333

            var e = 1; //operator precedence (BODMAS - Division and Multiplication have higher precedence than Addition and Subtraction)
            var f = 2;
            var g = 3;

            Console.WriteLine(e + f * g); //7

            var h = 1; //operator precedence (Parentheses give higher precedence to values inside them)
            var i = 2;
            var j = 3;

            Console.WriteLine((h + i) * j); //9

            var k = 1; //comparison operators return boolean values
            var l = 2;

            Console.WriteLine(k > l); //false
            Console.WriteLine(k < l); //true
            Console.WriteLine(k == l); //false
            Console.WriteLine(k != l); //true
            Console.WriteLine(!(k != l)); //False (because two negatives is a positive, bad practice, better to use one positive (k == l)

            var m = 1; //logical operators - return as true if both, or one or the other, or none are true, otherwise false
            var n = 2;
            var o = 3;

            Console.WriteLine(o > n && o > m); //true
            Console.WriteLine(o > n && o == m); //false (only one condition returned true and the AND operator was used)
            Console.WriteLine(o > n || o > m); //true (both true is true)
            Console.WriteLine(o > n || o == m); //true (only OR the other true is true)
            Console.WriteLine(o < n || o == m); //false (none are true is false)
            Console.WriteLine(!(o > n || o == m)); //NOT reverses the outcome of the comparisons in the parentheses
        }
    }
}
