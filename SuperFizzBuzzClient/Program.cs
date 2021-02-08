using System;
using System.Collections.Generic;
using HeadSpring.Core;

namespace SuperFizzBuzzClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var superFizzBuzz = new HeadSpring.Core.FizzBuzz(new Dictionary<int, string> { { 3, "Fizz" }, { 7, "Buzz" }, { 38, "Bazz" } });
            var op = superFizzBuzz.Process(new RangeNumbers(12, 145));
            foreach (var n in op)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
