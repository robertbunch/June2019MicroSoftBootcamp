using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace genericsLesson
{
    public class MainStore
    {
        public void RunStore()
        {
            var chair1 = new Chair(99.99f);
            var store = new Store<Chair>();
            store.Buy(chair1);
        }
    }

    public class Store<T> where T : class
    {
        public string Buy(T item)
        {
            Type myType = item.GetType();
            IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());
            foreach (PropertyInfo prop in props)
            {
                object propValue = prop.GetValue(item, null);
                Console.WriteLine(propValue);
            }

            Console.WriteLine("Purchased chair for {0}",item);
            return "success";
        }
    }

    public class Table
    {
        public bool Type { get; set; }
        public bool Price{ get; set; }
        //other stuff
    }
    public class Chair
    {
        public Chair(float price)
        {
            Price = price;
        }
        public bool Type { get; set; }
        public float Price { get; set; }
        //other stuff
    }
}
