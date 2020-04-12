using System;

namespace ObjectMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentOne = new Student("Leigh", "QA", 2.7);
            Student studentTwo = new Student("Jennifer", "Business Analayst", 3.6);

            Console.WriteLine(studentOne.HasHonours()); //run object method from class on each student
            Console.WriteLine(studentTwo.HasHonours());
        }
    }
}
