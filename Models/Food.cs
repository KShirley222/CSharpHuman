namespace Human.Models
{
    public class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        public  Food(string name, int cal, bool spice, bool sweet)
        {
            Name = name;
            Calories = cal;
            IsSpicy = spice;
            IsSweet = sweet;
        }
    }
}