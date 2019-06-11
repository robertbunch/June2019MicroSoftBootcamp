using System;
using System.Collections.Generic;
using System.Text;
using IronPython.Hosting;

namespace DynamicLessons
{
    class IronPy
    {
        static public void Run()
        {
            var pythonRT = Python.CreateRuntime();
            dynamic pythonFile = pythonRT.UseFile(@"C:\Users\rober\source\repos\DynamicLessons\DynamicLessons\Fight.py");
            pythonFile.run();
        }
    }
}
