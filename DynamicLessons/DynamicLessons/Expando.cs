using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;

namespace DynamicLessons
{
    public class Expando
    {
        public static void Run()
        {
            dynamic noWayShouldThisWork = new ExpandoObject();
            noWayShouldThisWork.name = "Rob";
            Console.WriteLine(noWayShouldThisWork.name);
            Console.WriteLine(noWayShouldThisWork.name.GetType());
            noWayShouldThisWork.addJob = (Action)(() => { noWayShouldThisWork.career = "Instructor"; });
            Console.WriteLine(noWayShouldThisWork.addJob);
            noWayShouldThisWork.addJob();
            Console.WriteLine(noWayShouldThisWork.career);
        }
       }
}
