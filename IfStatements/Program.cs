using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            I wake up                
            if I’m hungry                    ----condition true/false
                I eat breakfast              ----action if true
            
            I look at my phone
            if it’s about to die             ----condition true/false
                I charge it                  ----action if true

            I leave my house
            if it’s cloudy                   ----condition true/false
                I bring an umbrella          ----action if true
            otherwise
                bring sunglasses             ----action if not true
            */
            bool isMale = true;
            bool isTall = false;

            if (isMale) // simple way to check if a boolean variable is set to true
            {
                Console.WriteLine("You are male");
            } else
            {
                Console.WriteLine("You are not male");
            }

            if (isMale && isTall) // using AND in condition
            {
                Console.WriteLine("You are a tall male");
            } 
            else
            {
                Console.WriteLine("You are either not male or not tall or both");
            }

            if (isMale || isTall) // using OR in condition
            {
                Console.WriteLine("You are either tall or male or both");
            }
            else
            {
                Console.WriteLine("You are neither male nor tall");
            }

            if (isMale && isTall) // using AND in condition
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall) //if male but NOT tall (negation operator)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall) //if NOT male but tall (negation operator)
            {
                Console.WriteLine("You are not a male but you are tall");
            }
            else
            {
                Console.WriteLine("You are not male and not tall");
            }
        }
    }
}
