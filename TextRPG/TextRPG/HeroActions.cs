using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG
{
    public class HeroActions
    {
        public void Attack(Hero hero)
        {
            Console.WriteLine("{0} attacks with his {1}.",hero.Name,hero.SuperPower);
        }
        public void Rest(Hero hero)
        {
            Console.WriteLine("{0} goes to sleep. Hope nothing bad happens",hero.SecretIdentity);
        }
        public void DrinkPotion(Hero hero)
        {
            Console.WriteLine("{0} drinks the frosty brew and is reenergized to fight evil.", hero.Name);
        }
    }
}
