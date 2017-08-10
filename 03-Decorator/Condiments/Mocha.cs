using System;
using _03_Decorator.Beverages;

namespace _03_Decorator.Condiments
{
    public class Mocha : CondimentDecorator, ICondimentDecorator
    {

        public Mocha(IBeverage beverage) : base(beverage)
        {
        }

        public override string Description => _Beverage.Description + ", Mocha";
        public override double Cost => _Beverage.Cost + 0.20;

    }
}