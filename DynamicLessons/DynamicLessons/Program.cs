using System;

namespace DynamicLessons
{
    class Program
    {
        static void Main(string[] args)
        {

            dynamic n = 2;
            n = "Rob";
            n = "Are you serious?";

            //Dynamic101.Run();
            //DynamicXML.Run();
            //Expando.Run();
            IronPy.Run();
        }
        
    }
}
