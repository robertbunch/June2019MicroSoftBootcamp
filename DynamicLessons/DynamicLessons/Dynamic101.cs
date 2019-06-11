using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace DynamicLessons
{
    public class Dynamic101
    {
        public static void Run()
        {
            string msg = "This is a string. I know what methods and properties it has. -- The Compiler.";
            //msg.
            dynamic msg2 = "I don't know what this is. It's the CLR's problem. -- The Compiler.";
            //msg2++;

            int num = 10;
            Type type = num.GetType();
            Console.WriteLine(type);

        }
    }
}
