using System;
using System.Collections.Generic;
using System.Text;

namespace GettersAndSetters //close off access to class attributes by the public, private setting - if private, only code in the same class can access the attribute, if public all code can access
{
    class Movie
    {
        public string name; //class attributes
        public string director;
        private string rating; //not accessible by code in main program except by through property method getter setter
        //private string ratingTwo;

        public Movie(string aName, string aDirector, string aRating) //constructor
        {
            name = aName;
            director = aDirector;
            Rating = aRating;
            //ratingTwo = aRating;
        }

        public string Rating //PROPERTY METHOD - named as the private variable with Capital letter normally - contains getter and setter
        {
            get
            {
                return rating;
            }
            set
            {
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
