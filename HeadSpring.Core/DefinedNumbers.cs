using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace HeadSpring.Core
{
    public class DefinedNumbers : INumberStrategy, IDefinedNumbers
    {
        private IEnumerable<int> _numbers;
        public DefinedNumbers([NotNull] IEnumerable<int> numbers)
        {
            UpdateNumbers(numbers);
        }

        public void UpdateNumbers([NotNull] IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }
            this._numbers = numbers;
        }

        public IEnumerable<int> GetNumbers()
        {
            foreach (var n in _numbers)
            {
                yield return n;
            }
        }
    }
}
