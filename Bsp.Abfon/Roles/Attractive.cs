using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon.Roles
{
    public class Attractive : Role
    {
        public double[] PitchPath;

        public bool DisarmEnabled = true;

        public Attractive()
        {
            PitchPath = Generate.Sinusoidal(11, 192000, 1600000, 1);
        }

        public override double[] Move()
        {
            return Generate.Sinusoidal(63, 192000, Math.Pow(5.99, 14), 5);
        }


    }
}
