using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon.Roles
{
    public class OrganicRepair : Role
    {
        public double[] PitchPath;

        public OrganicRepair()
        {
            base.Name = "OrganicRepair";
        }

        public override double[] Move()
        {
            var d1 = Generate.Sinusoidal(63, 192000, Math.Pow(5.45, 14), 5);
            var d2 = Generate.Sinusoidal(63, 192000, Math.Pow(6.75, 14), 5);
            var l1 = new List<double>();
            l1.AddRange(d1);
            l1.AddRange(d2);

            return l1.ToArray();
        }

        public override void Thunk()
        {
            PitchPath = Generate.Sinusoidal(63, 192000, Math.Pow(5.99, 14), 5);
        }

    }
}
