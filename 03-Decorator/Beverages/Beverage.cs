namespace _03_Decorator.Beverages
{
    public abstract class Beverage : IBeverage
    {
        public Size Size { get; set; }
        public abstract string Description { get; }
        public abstract double Cost { get; }
    }
}