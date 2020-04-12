using System;

namespace GettersAndSetters //used to control access to class attributes, so that valid values can be restricted, and can only be chosen from valid options defined in the setter statement of the class
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13"); //possible ratings e.g. G, PG, PG-13, R, NR - if another value used as rating, then will be set to NR by "Rating" property method in the Movie class
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            
            //Console.WriteLine(avengers.ratingTwo); //when rating is private the attribute is not accessible
            Console.WriteLine(avengers.Rating);
        }
    }
}
