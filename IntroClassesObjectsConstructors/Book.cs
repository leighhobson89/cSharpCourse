using System;
using System.Collections.Generic;
using System.Text;

namespace IntroClassesObjectsConstructors
{
    class Book //think of a class as a custom data type blueprint. It contains "class attributes" which are variables declared inside the class
    {
        public string title; //class attributes
        public string author; 
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages) //constructor named as "public <nameOfClass>()", takes optional parameters from main program when it defines objects of this class and executes code upon creation of object
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;

            Console.WriteLine("Created " + title + " with " + pages + " pages, by " + author + "."); //example output summarises the data passed in to the class constructor when defining the object in the main program
        }
    }
}
