using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethodsAndClasses
{
    static class UsefulTools //class can be static, if it is, you can't create instances of it as objects e.g. "UsefulTools myUsefulTools = new UsefulTools();" would not be possible and so you could only use it for running static methods on i.e. in the case of the Math class built in to C#
    {
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
