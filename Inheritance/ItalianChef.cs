using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance 
{
    class ItalianChef : Chef // ItalianChef inherits all functionality from Chef
    {
        public override void MakeSpecialDish() //will change functionality of MakeSpecialDish() method in Chef.cs to be what we write here because we used override keyword
        {
            Console.WriteLine("The Italian Chef makes Pepperoni Pizza");
        }
        public void MakePasta()
        {
            Console.WriteLine("The Italian Chef makes Pasta");
        }
    }
}
