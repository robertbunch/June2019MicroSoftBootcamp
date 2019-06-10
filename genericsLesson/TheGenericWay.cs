using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericsLesson
{
    class TheGenericWay
    {
        public void Run()
        {
            // VS knows this isa generic so Intellisense is going to kick up T to remind us to pass type

            var result = new Result<int>{Success = true, Data = 5};
            var result2 = new Result<string> { Success = true, Data = "Hello" };
            var result3 = new Result<float> { Success = true, Data = 5.4f };
            Console.WriteLine(result.Success);
            Console.Write(result.Data);

            Console.WriteLine(result2.Success);
            Console.Write(result2.Data);

            Console.WriteLine(result3.Success);
            Console.Write(result3.Data);
        }
    }

    // carrots make it a generic
    // and we always use T to signify "Type"
    public class Result<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
    }
}
