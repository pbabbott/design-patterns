using System;

namespace _01_Strategy.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            this.quackBehavior = new Quack();
            this.flyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck!");
        }
    }
}
