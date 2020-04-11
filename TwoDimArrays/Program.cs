using System;

namespace TwoDimArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //  When array values known
            int[,] numberGrid = { //[,] tells C# that we are making a multi dimensional array, use one comma per dimension [,,] for three dimensions etc
                { 1, 2 //each element in array in its own angle brackets and has two or more sub-elements depending how many dimensions is the main array, in this case a two dimensional array with four elements
                },
                { 3, 4
                },
                { 5, 6
                },
                { 7, 8
                }
            };
            Console.WriteLine(numberGrid[3, 0]); // base0 [subArray, subArrayElement] e.g. [0,1] is first subArray and second subArrayElement

            // When array values not yet known
            int[,] myArray = new int[2, 3];
        }
    }
}
