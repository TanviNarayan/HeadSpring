using System;
using HeadSpring.Core;

namespace BasicFizzBuzzClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var basicFizzBuzz = new HeadSpring.Core.FizzBuzz();
            var op = basicFizzBuzz.Process(new RangeNumbers(1, 100));
            foreach (var n in op)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}