using System.Collections.Generic;

namespace HeadSpring.Core
{    public class RangeNumbers : INumberStrategy, IRangeNumbers
    {
        private int _from;
        private int _to;
        public RangeNumbers(int from, int to)
        {
            UpdateRange(from, to);
        }

        public void UpdateRange(int from, int to)
        {
            this._from = from;
            this._to = to;
        }

        public IEnumerable<int> GetNumbers()
        {
            for (int i = _from; i < _to + 1; i++)
            {
                yield return i;
            }
        }
    }
}