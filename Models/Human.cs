using System;

namespace Human
{
    public class Human
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

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        public Human(string name, int Str, int Int, int Dex, int Health )
        {
            Name = name;
            Strength = Str;
            Intelligence = Int;
            Dexterity = Dex;
            health = Health;
        }

        public int Attack(Human target)
        {
            if( target is Human)
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