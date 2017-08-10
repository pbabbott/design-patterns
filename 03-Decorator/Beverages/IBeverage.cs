namespace _03_Decorator.Beverages
{
    public interface IBeverage
    {
        Size Size { get; set; }
        string Description { get; }
        double Cost { get; }
    }
}