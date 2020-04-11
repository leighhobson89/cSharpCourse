using System;

namespace IntroClassesObjectsConstructors
{
    class Program
    {
        static void Main(string[] args) //An object is an instance of a class i.e. a physical object made up from the class template or "blueprint" referred to when creating it
        {
            Book book1 = new Book("The Return of Harry Potter","J.K. Rowling",400); //creation of book object "Book", then "book1" is the name given to the object, and then "new Book()" is saying we will make an instance of the Book template and pass in its information in the parentheses as defined in the class template constructor, and then it will be set up
            Book book2 = new Book("The Good Old Lord Of The Rings","J.R.R. Tolkien", 720);

            //Once they are setup they can be used in the main program and the coder can refer to any attributes or methods of the object that it contains ie book1.author or book2.pages etc and it will use the values passed in for those particular attributes
            int howManyPagesDoesBook2Have = book2.pages; // example of pulling out the data and using it to write to the console the number of pages for the book2 object
            Console.WriteLine(howManyPagesDoesBook2Have); //720 is output
            book2.pages = 1000; // can redefine an objects attribute
            int howManyPagesDoesBook2HaveNow = book2.pages;
            Console.WriteLine(howManyPagesDoesBook2HaveNow); //1000 is output
        }
    }
}
