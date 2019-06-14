using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG
{
    public class Hero
    {
        public delegate void HeroAction(Hero hero);
        public static void Attack()
        {

        }

        public string Name { get; set; }
        public string SuperPower { get; set; }
        public List<string> HeroInventory { get; set; }
        public string SecretIdentity { get; set; }

        public Action takeAction = Attack;
    }
}
