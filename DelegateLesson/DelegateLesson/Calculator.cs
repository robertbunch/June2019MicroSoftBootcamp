using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateLesson
{
    delegate void Operation(int number);

    class Calculator
    {
        public static void Run()
        {
            //Square(10);
            //Cube(4);
            Operation op = Square;
            ExecuteOperation(4, op);
            op = Cube;
            ExecuteOperation(5, op);
        }

        public static void Square(int num)
        {
            Console.WriteLine("{0} squared = {1}",num, num*num);
        }
        public static void Cube(int num)
        {
            Console.WriteLine("{0} cube = {1}", num, num *num*num);
        }
        static void ExecuteOperation(int num, Operation operation)
        {
            operation(num);
        }
    }
}
