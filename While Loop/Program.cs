using System;

namespace While_DoWhile_Loop
{
    class Program
    {
        static void Main(string[] args)
        //while loop checks condition, then runs code
        //do_while loop runs code, then checks condition so will always run at least once.

        {
            int index = 1;
            while (index <= 2) //while loops can be infinite if condition never becomes false so will cause a crash
            {
                Console.WriteLine(index);
                index++;
            }

            int indexTwo = 6;
            do
            {
                Console.WriteLine(indexTwo);
                indexTwo++;
            }
            while (indexTwo <= 3);
        }
    }
}
