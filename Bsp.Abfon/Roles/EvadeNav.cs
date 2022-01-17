using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon.Roles
{
    public class EvadeNav : Role
    {
        public double[] PitchPath;

        public EvadeNav()
        {
            base.Name = "EvadeNav";
        }

        public override double[] Move()
        {
            return Generate.Sinusoidal(63, 192000, Math.Pow(7.50, 14), 5);
        }

        public override void Thunk()
        {
            PitchPath = Generate.Sinusoidal(63, 192000, Math.Pow(5.99, 14), 5);
        }
    }
}
