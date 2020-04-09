using System;
using Human.Models;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanClass Kyle = new HumanClass("Kyle");
            Console.WriteLine($"{Kyle.Name} is losing his mind");
            Buffet firstBuffet = new Buffet();
            Console.WriteLine($"{Kyle.Name} got a {firstBuffet.Serve().Name}");
            Ninja carol = new Ninja("Carol");
            Console.WriteLine($"{carol.Name} is a ninja!");
            carol.Eat(firstBuffet.Serve());
            carol.Eat(firstBuffet.Serve());
            carol.Eat(firstBuffet.Serve());
            carol.Eat(firstBuffet.Serve());
            Wizard kyle = new Wizard("Kyle", 17, 19);
            Ninja steve = new Ninja("Steve",17, 19, 150 );
            Samurai john = new Samurai("John", 17, 19,80);
            kyle.DisplayStats();
            steve.DisplayStats();
            john.DisplayStats();
            // kyle.Attack(steve);
            steve.Attack(kyle);
            kyle.DisplayStats();
            john.Attack(steve);
            kyle.Heal(steve);
            john.Meditate();
            steve.Steal(kyle);
        }
    }
}
