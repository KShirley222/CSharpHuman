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
        }
    }
}
