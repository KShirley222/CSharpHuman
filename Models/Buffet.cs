using System;
using System.Collections.Generic;

namespace Human.Models
{
    public class Buffet
    {
          public List<Food> Menu;

          public Buffet ()
          {
              Menu = new List<Food>()
              {
                  new Food("Hash Brown", 1000, true, false),
                  new Food("Salad", 200, false, false ),
                  new Food("Bo Saam Pork", 800, true, true),
                  new Food("Ice Cream", 700, false, true),
                  new Food("Coffee", 150, false, false),
                  new Food("Sammy", 650, true, false),
                  new Food("Mango", 250, false, true),

              };
          }

            public Food Serve()
            {
                Random foodItem = new Random();
                Food item = Menu[foodItem.Next(Menu.Count)];
                Console.WriteLine($"The {item.Name} is so tasty!");
                return item;
            }
          
          
    }
}