using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon
{
    public class Role
    {
        public string Name;

        public double PathPosition;
        
        public virtual double[] Move()
        {
            return new double[0];
        }

        public virtual void Thunk()
        {
        }
    }
}
