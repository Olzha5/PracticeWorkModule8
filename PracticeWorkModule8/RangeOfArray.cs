using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWorkModule8
{
    public class RangeOfArray
    {
        private int[] _array;
        private int _lowerBound;
        private int _upperBound;

        public RangeOfArray(int lowerBound, int upperBound)
        {
            _lowerBound = lowerBound;
            _upperBound = upperBound;
            _array = new int[upperBound - lowerBound + 1];
        }

        public int this[int index]
        {
            get
            {
                if (index < _lowerBound || index > _upperBound)
                    throw new IndexOutOfRangeException("Индекс за пределами диапазона");
                return _array[index - _lowerBound];
            }
            set
            {
                if (index < _lowerBound || index > _upperBound)
                    throw new IndexOutOfRangeException("Индекс за пределами диапазона");
                _array[index - _lowerBound] = value;
            }
        }
    }
}
