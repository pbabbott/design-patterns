using System;
using _01_Strategy.Ducks;

namespace _01_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck d = new MallardDuck();
            d.PerformFly();
            d.PerformQuack();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();

            Console.WriteLine("\nProgram Terminated.");
        }
    }
}
