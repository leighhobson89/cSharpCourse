using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 }; //init array
            for(int i=0; i < luckyNumbers.Length; i++) // for (init iterator variable; condition; increment/decrement iterator)
            {
                Console.WriteLine(luckyNumbers[i]); //write out all values of array
            }
        }
    }
}
