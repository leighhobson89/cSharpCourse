using System;

namespace Inheritance // a class that can do everything another class can do plus more can "inherit" everything from that "super" class and is called a "sub class"
{
    /*
     * A sub class can inherit everything of a super class by defining it with "<name> : <name of super class>"
     * A sub class can automatically do everything the super class can do, PLUS extra methods and functionality added, which the super class will not be able to do
     * Method functionality in super class can be overridden by using the "override" keyword in a sub class, on a method that has "virtual" keyword in the super class
    */
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef(); //super class
            chef.MakeChicken();
            chef.MakeSpecialDish(); // makes the basic special dish defined in the Chef.cs super class

            ItalianChef italianchef = new ItalianChef(); // sub class inherits from super class
            italianchef.MakeChicken();
            italianchef.MakePasta(); //can only be run by the sub class with the extra method MakePasta
            italianchef.MakeSpecialDish();  //makes the sub class special dish by the override keyword
        }
    }
}
