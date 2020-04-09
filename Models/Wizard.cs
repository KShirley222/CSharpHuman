using System;

namespace Human.Models
{
    public class Wizard : HumanClass
    {
        public Wizard(string name, int str, int dex) : base(name, str, 25, dex, 50)
        {
            Console.WriteLine($"{name} is a Wizard");
        }

        public override int Attack( HumanClass target )
            {
                if( target is HumanClass)
                {
                    int dmg = 5 * Intelligence;
                    target.Health -= dmg;
                    this.Health += dmg;
                    Console.WriteLine($"{Name} casted a fire spell at {target.Name}! ");
                    Console.WriteLine($"{target.Name} took {dmg} damage and has {target.Health} health left.");
                    Console.WriteLine($"{this.Name} gained { dmg } health and now has {this.Health}");
                    return target.Health;
                }
                else
                {
                    throw new Exception("You can't attack that!");
                }
            }
        public int Heal(HumanClass target)
        {

            int heals = 10 * this.Intelligence;
            target.Health += heals;
            Console.WriteLine($"{this.Name} heals {target.Name} for {heals} health from {target.Health-heals}, and now has {target.Health}");
            return target.Health;
        }
        
        
    }
}


