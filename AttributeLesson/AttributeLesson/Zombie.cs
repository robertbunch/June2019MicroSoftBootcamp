using System;
using System.Collections.Generic;
using System.Text;

namespace AttributeLesson
{
    [Serializable]
    public class Zombie
    {
        public string Name { get; set; }
        public string Weapon { get; set; }
        public int DaysSinceInfected { get; set; }
        public float Health { get; set; }
        public void Attack()
        {
            Console.WriteLine("Zombie lashes out with {0}",Weapon);
        }
    }
}
