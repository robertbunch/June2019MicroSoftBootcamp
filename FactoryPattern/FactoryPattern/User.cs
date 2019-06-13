using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class User
    {
        public string Name{ get; private set; }
        public string Company { get; private set; }
        public string SalesPerson { get; private set; }
    
        internal User(string Name, string Company, string SalesPerson)
        {

        }

        public static User CreateNewUser(string name, string company, string salesPerson)
        {
            return new User(name, company, salesPerson);
        }

    }

}
