namespace _03_Decorator.Beverages
{
    public class Decaf : Beverage, IBeverage
    {
        public override string Description => "Decaf";
        public override double Cost => 1.05;
    }
}