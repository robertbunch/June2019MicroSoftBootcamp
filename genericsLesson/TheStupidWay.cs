using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericsLesson
{
    class TheStupidWay
    {
        public void Run()
        {
            //call service, etc.
            var result = new Result { Success = true, Data = 5 };
            Console.WriteLine(result.Success);
            Console.WriteLine(result.Data);

            var result2 = new Result2 { Success = false, Data = "Hello" };
            Console.WriteLine(result2.Success);
            Console.WriteLine(result2.Data);

        }

        public class Result
        {
            public bool Success { get; set; }
            public int Data { get; set; }
        }
        //as soon as I get another dependency... I copy above and change for the new data type it returns (assuming not int)
        public class Result2
        {
            public bool Success { get; set; }
            public string Data { get; set; }
        }
        //And then a third one happens and retuns a bool...
        //This is a big problem

    }
}
