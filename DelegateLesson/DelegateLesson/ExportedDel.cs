using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateLesson
{

    public delegate void SendTextDel();
    class ExportedDel
    {
        static void SendTextMessage()
        {
            Console.WriteLine("I just sent a text message");
        }
        public static SendTextDel ExportDelegate()
        {
            return new SendTextDel(SendTextMessage);
        }
    }
}
