using System;
using System.Collections.Generic;
using System.Text;

namespace Wc.Pieces
{
    public abstract class PieceBase
    {

        public int Lives { get; protected set; }

        public double Energy { get; protected set; }

        public double Speed { get; protected set; }

        public double Hope { get; protected set; }
        public double Risk { get; protected set; }

        public virtual void Think ()
        {

        }


    }

}
