using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon
{
    public class NRoleComp
    {
        public NRoleComp()
        {
            
        }

        public Size OrgainicGather = Size.Medium;
        public Size OrganicRepair = Size.Medium;
        public Size Attack = Size.Medium;
        public Size Gather = Size.Medium;
        public Size Builder = Size.Medium;
        public Size Repair = Size.Medium;
        public Size Defend = Size.Medium;
        public Size PointNav = Size.Medium;
        public Size EvadeNav = Size.Medium;
        public Size TacticleNav = Size.Medium;
        public Size Targeting = Size.Medium;
    }

    public enum Size
    {
        Small,
        Medium,
        Large,
        Massive,
        None
    }
}
