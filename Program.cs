using System;

namespace TryInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstClass first = new();
            first.hello();

            SecondClass second = new();

            second.hello();

            Console.WriteLine(first is FirstClass);
            Console.WriteLine(first is IFirstInterface);
            Console.WriteLine(first is ISecondInterface);

            Console.WriteLine(second is SecondClass);
            Console.WriteLine(second is IFirstInterface);
            Console.WriteLine(second is ISecondInterface);
        }
    }

    interface IFirstInterface
    {
        void hello();
    }

    interface ISecondInterface
    {
        void byTwo(int i);
    }

    class FirstClass : IFirstInterface
    {
        public void hello()
        {
            Console.WriteLine("Hello There!");
        }
    }

    class SecondClass : IFirstInterface, ISecondInterface
    {
        public void hello()
        {
            Console.WriteLine("Hello Again");
        }

        public void byTwo(int i)
        {
            Console.WriteLine(i * 2);
        }
    }

}
