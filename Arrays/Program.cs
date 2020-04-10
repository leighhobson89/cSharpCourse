using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            Console.WriteLine( luckyNumbers[0]); //prints out [0] index of array

            string[] friends = new string[3]; //array defined and set to hold 3 elements
            friends[0] = "Jim"; //elements of array defined
            friends[1] = "Kelly";
            friends[2] = "Roger";
            foreach (var item in friends) // iterate through array and print out each element
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
