using System;
using System.Collections.Generic;
namespace TextRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new List<string>();
            var lane = new Hero() { Name = "The Tick", HeroInventory = inventory, SecretIdentity = "Lane", SuperPower = "Crazy Strong" };
            var actions = new HeroActions();
            //actions.Attack(lane);
            //actions.DrinkPotion(lane);
            //Laugh(lane);
            HeroAction attack = actions.Attack;
            HeroAction drink = actions.DrinkPotion;
            HeroTakeAction.Action(lane, attack);
            HeroTakeAction.Action(lane, drink);
            HeroAction laugh = Laugh;
            HeroTakeAction.Action(lane, laugh);

            HeroTakeAction.Action(lane, () => {
                Console.WriteLine("Hero runs away!");
            });


        }
        private static void Laugh(Hero hero)
        {
            Console.WriteLine("The mighty {0} laughs at evil.",hero.Name);
        }
    }
}
