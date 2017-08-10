using System;
using _03_Decorator.Beverages;

namespace _03_Decorator.Condiments
{
    public class Milk : CondimentDecorator, ICondimentDecorator
    {
        public Milk(IBeverage beverage) :base(beverage)
        {
        }

        public override string Description => ", Milk";
        public override double Cost => _Beverage.Cost + .10;

    }
}