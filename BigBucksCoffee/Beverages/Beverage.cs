namespace BigBucksCoffee
{
    public abstract class Beverage : IBeverage
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private double _price;

        public virtual double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Image { get; set; }

        public Beverage(int id, string name, string description, double price, string image = "Images/coffee2.jpeg")
        {
            ID = id;
            Name = name;
            Description = description;
            Price = price;
            Image = image;
        }

        public override string ToString()
        {
            return $"ID:{ID} Name:{Name} Price:{Price} Description:{Description}";
        }
    }
}