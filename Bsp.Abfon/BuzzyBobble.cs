using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon
{
    public class BuzzyBobble
    {

        int _target;
        int _source;
        int _count;


        public BuzzyBobble(Tuple<int, int> ts, int count)
        {
            _target = ts.Item2;
            _source = ts.Item1;
            _count = count;

        }
    }
}
