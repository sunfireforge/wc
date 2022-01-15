using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon
{
    public class NRoleComp
    {
        public Size Gather = Size.Small;
        public Size Builder = Size.Small;
        public Size Repair = Size.Medium;
        public Size Attack = Size.Medium;
        public Size Defend = Size.Medium;
        public Size PointNav = Size.Small;
        public Size EvadeNav = Size.Small;
        public Size TacticleNav = Size.Small;
        public Size Targeting = Size.Small;
    }

    public enum Size
    {
        Small,
        Medium,
        Large
    }
}
