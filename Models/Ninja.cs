using System;
using System.Collections.Generic;

namespace Human.Models
{
    public class Ninja : HumanClass
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        public Ninja(string name) : base(name)
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
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
    }
}