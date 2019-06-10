using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //var genericWay = new TheGenericWay();
            //var stupidWay = new TheStupidWay();
            //genericWay.Run();
            //stupidWay.Run();
            //var reverseArray = new ReverseArray<int>();

            //var newA = ReverseArray<int>.ReverseArrayFunc(new int[] { 1,2,3,4,5} );
            //var newAb = ReverseArray<string>.ReverseArrayFunc(new string[] { "toast", "jam", "bread", "knife" });
            //foreach (var e in newA)
            //{
            //    Console.WriteLine(e);
            //}
            //foreach (var e in newAb)
            //{
            //    Console.WriteLine(e);
            //}
            //var store = new MainStore();
            //store.RunStore();

            List<string> parts = new List<string>() { "one", "two" };
            var myList = new List<int> { 1, 2, 3, 4 };
            foreach (var item in parts)
            {
                Console.WriteLine(item);
            }

        }
    }
}
