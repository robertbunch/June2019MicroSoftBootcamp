using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericsLesson
{
    class GenericsAbstract1
    {
        public void Run()
        {
            // VS knows this isa generic so Intellisense is going to kick up T to remind us to pass type

            var result = new Result2<int> { Success = true, Data = 5 };
            var result2 = new Result2<string> { Success = true, Data = "Hello" };
            var result3 = new Result2<float> { Success = true, Data = 5.4f };
            var helper = new Result2Printer();
            helper.Print(result);
            helper.Print(result2);
            helper.Print(result3);
        }
    }

    // carrots make it a generic
    // and we always use T to signify "Type"
    public class Result2<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
    }

    public class Result2Printer
    {
        //we want to pass in an instance of a result and print it out
        public void Print<T>(Result2<T> result)
        {
            Console.WriteLine(result.Success);
            Console.Write(result.Data);
        }
    }
}