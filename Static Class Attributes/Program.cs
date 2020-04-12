using System;

namespace Static_Class_Attributes //static variables are on the class not the object instance and are referred by class name i.e. Song.songCount for a static attribute "songCount" belonging to class "Song.cs"
{
    class Program
    {
        static void Main(string[] args) //static is an attribute on the class itself rather than an object of the class, so will be applied to all instances of that class
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount); //print out how many objects have been created due to incrementer in class constructor
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);
            Console.WriteLine(holiday.getSongCount()); //alternative way to get the static attribute in to the object using a return command in a seperate method
        }
    }
}
