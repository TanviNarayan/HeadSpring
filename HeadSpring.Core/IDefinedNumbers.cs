using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace HeadSpring.Core
{
    public interface IDefinedNumbers
    {
        void UpdateNumbers([NotNull] IEnumerable<int> numbers);
    }
}