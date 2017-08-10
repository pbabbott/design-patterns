using System;
using _03_Decorator.Beverages;
using _03_Decorator.Condiments;

namespace _03_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IBeverage beverage0 = new Espresso();
            Console.WriteLine($"beverage0: {beverage0.Description} ${beverage0.Cost}");


            IBeverage beverage1 = new DarkRoast();
            beverage1 = new Mocha(beverage1);
            beverage1 = new Mocha(beverage1);
            beverage1 = new Whip(beverage1);
            Console.WriteLine($"beverage1: {beverage1.Description} ${beverage1.Cost}");

            IBeverage beverage2 = new HouseBlend();
            beverage2 = new Soy(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine($"beverage2: {beverage2.Description} ${beverage2.Cost}");

        }
    }
}
