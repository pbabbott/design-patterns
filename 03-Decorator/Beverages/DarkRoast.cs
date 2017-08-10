namespace _03_Decorator.Beverages
{
    public class DarkRoast : Beverage, IBeverage
    {
        public override string Description => "Dark Roast Coffee";
        public override double Cost => 0.99;
    }
}