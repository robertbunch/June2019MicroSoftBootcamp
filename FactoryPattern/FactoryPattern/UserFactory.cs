using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class UserFactory
    {
        public static User MakeUser(object obj)
        {
            return new User("Rob", "MS", "Lane");
        }
    }
}
