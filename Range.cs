using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranges
{

    public class RangeEnumerator : IEnumerator<int>
    {
        public RangeEnumerator(Range t)
        {
            theRange = t;
            current = theRange.depart - theRange.direction;
        }

        Range theRange;
        int current;

        int IEnumerator<int>.Current => current;

        object System.Collections.IEnumerator.Current => current;

        public void Dispose()
        { }

        public bool MoveNext()
        {
            if (current == theRange.arrivee - theRange.direction)
            {
                return false;
            }
            current += theRange.direction;
            return true;
        }

        public void Reset()
        {
            current = theRange.depart - theRange.direction;
        }
    }

    public class Range : IEnumerable<int>
    {
        internal int depart;
        internal int arrivee;
        internal int direction;

        public Range(int depart, int arrivee)
        {
            this.depart = depart;
            this.arrivee = arrivee;
            if (depart < arrivee)
            {
                direction = +1;
            }
            else
            {
                direction = -1;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new RangeEnumerator(this);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new RangeEnumerator(this);
        }
    }
}
