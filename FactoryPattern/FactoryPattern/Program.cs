using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //   var user = new User("Rob", "MS", "Lane");
            var user = UserFactory.MakeUser(new object());
        }
    }
}
