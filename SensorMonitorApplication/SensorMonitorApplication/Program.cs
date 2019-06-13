using System;
using System.Net.Http;
using System.Text;

namespace SensorMonitorApplication
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            SendPost();
            Console.ReadKey();
        }
        public async static void SendPost()
        {
            string myJson = "{'sid':3,'value':97,'type':'Temperature'}";

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(
                "https://prod-126.westus.logic.azure.com:443/workflows/0c5938c46aff41cfba3ef238690daa33/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=LQqhoOEuidodO5hYqo6lOvOlcI_sE2r1tRcu5pFqwl4",
                new StringContent(myJson, Encoding.UTF8, "application/json"));
                Console.WriteLine(response.StatusCode);
            }
        }
    }
}
