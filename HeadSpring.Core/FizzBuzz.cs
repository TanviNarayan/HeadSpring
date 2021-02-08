using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace HeadSpring.Core
{
    public interface IFizzBuzz
    {
        IEnumerable<string> Process([NotNull] INumberStrategy numberStrategy);
    }
    public class FizzBuzz: IFizzBuzz
    {
        private static readonly Dictionary<int, string> defaultRules = new Dictionary<int, string>
        {
            {3, "Fizz"},
            {5, "Buzz"}
        };

        public FizzBuzz() : this(defaultRules)
        {

        }

        private readonly Dictionary<int, string> _gameRules;
        public FizzBuzz(Dictionary<int, string> gameRules)
        {
            _gameRules = gameRules;
        }
        
        public IEnumerable<string> Process([NotNull] INumberStrategy numberStrategy)
        {
            if (numberStrategy == null)
            {
                throw new ArgumentNullException(nameof(numberStrategy));
            }
            var finalOutput = new List<string>();
            foreach (var number in numberStrategy.GetNumbers())
            {
                StringBuilder sb = new StringBuilder();
                foreach (var gameRule in _gameRules)
                {
                    if (number % gameRule.Key == 0)
                    {
                        sb.Append(gameRule.Value);
                    }
                }

                finalOutput.Add(sb.Length > 0 ? sb.ToString() : number.ToString());
            }

            return finalOutput;
        }
    }
}