using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Reflection;

namespace AttributeLesson
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class NetworkDataAttribute : Attribute
    {

    }

    [NetworkData]
    class Program
    {
        static void Main(string[] args)
        {
            var zombie1 = new Zombie { Weapon = "axe", DaysSinceInfected = 3, Health = 11.2f, Name = "Hank" };
            zombie1.Attack();
            //Let's serialize our zombie1 so we can reproduce him easily
            var formatter = new BinaryFormatter();
            var memoryStream = new MemoryStream();
            formatter.Serialize(memoryStream, zombie1); // serialize our zombie, and put him into memoryStream

            //We are now on the otherside of the program. We got the memoryStream. What's in it?
            //Seek will move the marker back to the beginning of the memory stream
            memoryStream.Seek(0, SeekOrigin.Begin);
            var zombie2 = formatter.Deserialize(memoryStream) as Zombie; //the memory stream is at the beginning, deserialize our object
            Console.WriteLine(zombie2.Name);
            Program.GetAssem();
        }

        static void GetAssem()
        {

            Assembly assembly = typeof(Zombie).Assembly;
            var attributes = assembly.GetCustomAttributes();
            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute.ToString());
            }
        }
    }
}
