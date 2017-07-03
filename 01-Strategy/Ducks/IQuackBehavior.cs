using System;

namespace _01_Strategy.Ducks
{
    public interface IQuackBehavior
    {
        void Quack();
    }

    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack! Quack! Quack!");
        }
    }

    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }

    public class SqueakQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak!");
        }
    }

}
