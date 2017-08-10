namespace _03_Decorator.Beverages
{
    public class HouseBlend : Beverage, IBeverage
    {
        public override string Description => "House Blend Coffee";
        public override double Cost => 0.89;
    }
}