namespace BigBucksCoffee
{
    public class Soda : Beverage
    {
        public bool IsDiet { get; set; }
        public bool IsSparkling{ get; set; }
        public bool HasCaffeine { get; set; }
        public override double Price { get; set; }

        public Soda(int id, string name, string description, double price, string image, bool isDiet, bool isSparkling, bool hasCaffeine)
       : base(id, name, description, price, image)
        {
            Price = price;
            IsDiet = isDiet;
            IsSparkling = isSparkling;
            HasCaffeine = hasCaffeine;
        }
        public override string ToString()
        {
            string diet = IsDiet ? "Light" : "";
            string sparkling = IsSparkling ? "Contains bubbles. " : "";
            string caffeine = HasCaffeine ? "With caffeine. " : "";
            return base.ToString() + $"{diet}{sparkling}{caffeine}";
        }
    }
}