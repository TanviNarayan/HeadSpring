using System.Collections.Generic;

namespace HeadSpring.Core
{
    public interface INumberStrategy
    {
        IEnumerable<int> GetNumbers();
    }
}