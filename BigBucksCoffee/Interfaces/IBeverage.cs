namespace BigBucksCoffee
{
    public interface IBeverage
    {
        int ID { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        double Price { get; set; }
        string Image { get; set; }
    }
}