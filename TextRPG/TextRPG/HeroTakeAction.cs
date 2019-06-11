using System;
using System.Collections.Generic;
using System.Text;

namespace TextRPG
{
    public delegate void HeroAction(Hero hero);
    public class HeroTakeAction
    {
        public static void Action(Hero hero, HeroAction heroActionHandler)
        {
            //check to see if the hero is alive
            //if (hero.Health > 0) { }
            heroActionHandler(hero);
            //add results to db
            //add xp, change health
        }
    }
}
