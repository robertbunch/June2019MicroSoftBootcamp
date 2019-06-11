using System;

namespace DelegateLesson
{

    delegate void MyDel();

    class Program
    {
        static void Main(string[] args)
        {
            Program.SayHello();
            MyDel del = SayHello;
            del();
        }
        static void SayHello()
        {
            Console.WriteLine("Hello");
            
        }
    }
}
