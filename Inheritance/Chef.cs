using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }
        public virtual void MakeSpecialDish() //virtual keyword allows ability to be overridden by subclasses using keyword "override" i.e. change the functionality of this method within methods called in the subclass
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}
