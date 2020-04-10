using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
            byte a = 1;
            int i = a;
            Console.WriteLine(i);

            //explicit conversion(casting)
            int b = 2; // if value higher than 255 is used, data loss occurs as value is higher than max range of 'byte' data type, so value is wrong (e.g. 2000 gives 208)
            byte j = (byte)b;
            Console.WriteLine(j);

            //non compatible conversions - string => integer
            string number = "1234";
            int k = Convert.ToInt32(number);
            Console.WriteLine(k);

            //non compatible conversions - string => boolean
            string str = "true";
            bool l = Convert.ToBoolean(str);
            Console.WriteLine(l);

            //non compatible conversions to lesser data types (causes exception "Value was either too large or too small for an unsigned byte")
            try //try stops crashing by running catch block if this following code fails
            {
                string numberThree = "1234";
                int m = Convert.ToByte(numberThree);
                Console.WriteLine(m);
            }
            catch (Exception) // outputs a friendly message to user and stops crashing.
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }
        }
    }
}
