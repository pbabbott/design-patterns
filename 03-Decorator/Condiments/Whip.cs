using System;
using _03_Decorator.Beverages;

namespace _03_Decorator.Condiments
{
    public class Whip : CondimentDecorator, ICondimentDecorator
    {

        public Whip(IBeverage beverage) : base(beverage)
        {
        }

        public override string Description => _Beverage.Description + ", Whip";
        public override double Cost => _Beverage.Cost + .15;
    }
}