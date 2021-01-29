namespace BigBucksCoffee
{
    public class Tea : Beverage
    {
        public bool HasMilk { get; set; }
        public bool HasSugar { get; set; }
        public bool HasHoney { get; set; }
        public bool HasLemon { get; set; }
        public override double Price { get; set; }

        public Tea(int id, string name, string description, double price, string image, bool hasMilk, bool hasSugar, bool hasHoney, bool hasLemon)
        : base(id, name, description, price, image)
        {
            Price = price;
            HasMilk = hasMilk;
            HasSugar = hasSugar;
            HasHoney = hasHoney;
            HasLemon = hasLemon;
        }

        public override string ToString()
        {
            string milk = HasMilk ? " With Milk" : "";
            string sugar = HasSugar ? " With Sugar" : "";
            string honey = HasHoney ? " With Honey" : "";
            string lemon = HasLemon ? " With Lemon" : "";
            return base.ToString() + $"{ milk} {sugar} {honey} {lemon}";
        }
    }
}