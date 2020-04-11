using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convert numbers to days of the week
            Console.WriteLine(GetDay(1)); //pass in a day of the week in number format and write result as a day
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch(dayNum)
            {
                case 0: //if number passed in is 0, then set dayName to be "Sunday"
                    dayName = "Sunday";
                    break; //required if want to make it stop checking after first one is true
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default: //if none are true then return this value
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }
    }
}
