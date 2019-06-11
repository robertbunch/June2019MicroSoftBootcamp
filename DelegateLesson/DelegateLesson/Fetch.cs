using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace DelegateLesson
{

    public delegate void DBdel();

    public class Fetch
    {

        public static void AddToDB()
        {
            Console.WriteLine("I added something to the db");
        }

        public static void GetJson(DBdel del, string apiUrl)
        {
            WebRequest webRequest = WebRequest.Create(apiUrl);
            WebResponse webResponse = webRequest.GetResponse();
            StreamReader reader = new StreamReader(webResponse.GetResponseStream());
            string jsonAsString = reader.ReadLine();
            while(jsonAsString != null)
            {
                Console.WriteLine(jsonAsString);
                jsonAsString = reader.ReadLine(); 
            }
            del();
        }


    }
}
