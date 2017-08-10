using System;
using _03_Decorator.Beverages;

namespace _03_Decorator.Condiments
{
    public class Soy : CondimentDecorator, ICondimentDecorator
    {

        public Soy(IBeverage beverage) : base(beverage)
        {
        }

        public override string Description => _Beverage.Description + ", Soy";
        public override double Cost => _Beverage.Cost + .15;
    }
}