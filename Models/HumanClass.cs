using System;

namespace Human.Models
{
    public class HumanClass
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        public int Health
        {
            get
            {
               return health; 
            }
        }

        public HumanClass(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        public HumanClass(string name, int Str, int Int, int Dex, int Health )
        {
            Name = name;
            Strength = Str;
            Intelligence = Int;
            Dexterity = Dex;
            health = Health;
        }

        public int Attack(HumanClass target)
        {
            if( target is HumanClass)
            {
                int dmg = 5 * Strength;
                target.health -= dmg;
                Console.WriteLine($"{Name} devlivered a punishing blow to {target.Name}! ");
                return target.health;
            }
            else
            {
                throw new Exception("You can't attack that!");
            }
        }
    }
}