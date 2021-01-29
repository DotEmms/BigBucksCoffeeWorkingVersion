namespace BigBucksCoffee
{
    public class Coffee : Beverage
    {
        public bool HasMilk { get; set; }
        public bool HasSugar { get; set; }
        public bool HasAlcohol { get; set; }
        public override double Price { get; set; }

        public Coffee(int id, string name, string description, double price, string image, bool hasMilk, bool hasSugar, bool hasAlcohol )
        : base(id, name, description, price, image)
        {
            Price = price;
            HasMilk = hasMilk;
            HasSugar = hasSugar;
            HasAlcohol = hasAlcohol;
        }

        public override string ToString()
        {
            string milk = HasMilk ? " With Milk" : "";
            string sugar = HasSugar ? "Contains sugar. " : "";
            string alcohol = HasAlcohol ? "With happy juice. " : "";
            return base.ToString() + $"{milk}{sugar}{alcohol}";
        }
    }
}