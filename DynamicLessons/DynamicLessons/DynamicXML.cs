using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
namespace DynamicLessons
{
    public class DynamicXML
    {
        public static void Run()
        {
            string data = File.ReadAllText(@"C:\Users\rober\source\repos\DynamicLessons\DynamicLessons\Books.json");
            // we (compiler) dont know whats in there, so we will use dynamic
            dynamic obj = JsonConvert.DeserializeObject<dynamic>(data);
            foreach (var book in obj)
            {
                //Console.WriteLine(book);
                var title = book.title;
                Console.WriteLine(title);
                if(book.genre == "Fantasy")
                {
                    book.favorite = "Favorite";
                }
                //Console.WriteLine("{0} by {1}",book.title, book.title );
            }
            string str = JsonConvert.SerializeObject(obj);
            Console.WriteLine(str);
        }
    }
}
