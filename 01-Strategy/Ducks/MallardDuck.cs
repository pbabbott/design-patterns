using System;

namespace _01_Strategy.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.quackBehavior = new Quack();
            this.flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck!");
        }
    }
}
