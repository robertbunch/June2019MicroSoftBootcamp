using System;

namespace DelegateLesson
{

    delegate void MyDel();

    class Program
    {
        static void Main(string[] args)
        {
            DBdel del = Fetch.AddToDB;
            //Fetch.GetJson(del, "https://api.openweathermap.org/data/2.5/weather?q=Atlanta&units=imperial&appid=e312dbeb8840e51f92334498a261ca1d");
            Calculator.Run();
            //SayHello();
            //MyDel del = SayHello;
            //del();
        }
        static void SayHello()
        {
            Console.WriteLine("Hello");

        }
    }
}
