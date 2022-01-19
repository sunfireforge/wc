using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon.Roles
{
    public class Defend : Role
    {
        public double[] PitchPath;

        public bool DisarmEnabled = true;

        public Defend()
        {
            PitchPath = Generate.Sinusoidal(11, 192000, Math.Pow(2.10, 14), 1);
        }

        public override double[] Move()
        {
            return Generate.Sinusoidal(63, 192000, Math.Pow(5.99, 14), 5);
        }
    }
}
