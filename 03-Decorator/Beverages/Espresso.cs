namespace _03_Decorator.Beverages
{
    public class Espresso : Beverage, IBeverage
    {
        public override string Description => "Espresso";
        public override double Cost => 1.99;
    }
}