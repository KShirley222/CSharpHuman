using System;

namespace Human.Models
{
    public class Samurai : HumanClass
    {
        public Samurai(string name, int str, int intel, int dex):  base(name, str, intel, dex, 200)
        {
            Console.WriteLine($"{name} is a Samuri");
        }

        public override int Attack(HumanClass target)
        {
            if(target.Health <= 50){
                Console.WriteLine($"{this.Name} took advantage of {target.Name}'s weakend state and killed them in cold blood");
                target.Health = 0;
                return target.Health;
            }else{
            base.Attack(target);

            return target.Health;
            }

        }

        public int Meditate()
        {
            // no max health stat, so just heal for 100
            int heals = 100;
            this.Health += heals;
            Console.WriteLine($"{this.Name} heals for {heals} health from {this.Health-heals}, and now has {this.Health}");
            return this.Health;
        }
    }
}