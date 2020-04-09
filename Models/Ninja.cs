using System;
using System.Collections.Generic;

namespace Human.Models
{
    public class Ninja : HumanClass
    {
        Random rand = new Random();
        private int calorieIntake;
        public List<Food> FoodHistory;
        public Ninja(string name) : base(name)
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        public Ninja(string name, int str, int intel, int hp) : base(name, str, 175, intel, hp)
        {
             Console.WriteLine($"{name} is a Ninja");
        }

        public bool IsFull{
            get{
                if(calorieIntake > 1200){
                    return true;
                }else{
                    return false;
                }

            }
        }
        public void Eat(Food item)
        {
            FoodHistory.Add(item);
            calorieIntake = calorieIntake + item.Calories;
            Console.WriteLine(FoodHistory);
            Console.WriteLine ( calorieIntake);
            if(IsFull){
                Console.WriteLine("I'm full.");
            }
            else{
                calorieIntake += item.Calories;
            }
        }

        public override int Attack( HumanClass target )
        {
            if( target is HumanClass)
            {
                int critical = rand.Next(1,6);
                int dmg = 5 * Dexterity;

                if(critical == 1){
                    dmg+= 10;
                    target.Health -= dmg;
                    Console.WriteLine($"{this.Name} critically  kicked {target.Name} in the face! ");
                    Console.WriteLine($"{target.Name} took {dmg} damage and has {target.Health} health left.");
                    return target.Health;
                }else{
                    target.Health -= dmg;
                    Console.WriteLine($"{Name} kicked {target.Name}! ");
                    Console.WriteLine($"{target.Name} took {dmg} damage and has {target.Health} health left.");
                    
                    return target.Health;

                }
            }
            else
            {
                throw new Exception("You can't attack that!");
            }
        }  
        public void Steal(HumanClass target)
        {
            int stealHealth = 5; 
            target.Health -= stealHealth;
            this.Health = this.Health + stealHealth;
            Console.WriteLine($"{target.Name} took {stealHealth} damage and has {target.Health} health left.");
            Console.WriteLine($"{this.Name} took {stealHealth}  health from {target.Name} and has {this.Health} health left.");

        }
    }
}