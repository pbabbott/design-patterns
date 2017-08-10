using _03_Decorator.Beverages;

namespace _03_Decorator.Condiments
{
    public abstract class CondimentDecorator : ICondimentDecorator
    {
        protected readonly IBeverage _Beverage;

        public CondimentDecorator(IBeverage beverage)
        {
            this._Beverage = beverage;
        }


        public Size Size { get => _Beverage.Size; set => _Beverage.Size = value; }
        public abstract string Description { get; }
        public abstract double Cost { get; }
    }
}