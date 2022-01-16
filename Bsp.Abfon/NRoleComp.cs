using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon
{
    public class NRoleComp
    {

        public Dictionary<string, int> RoleGroups;

        public NRoleComp()
        {
            RoleGroups = new Dictionary<string, int>
            {
                { "OrgainicGather", (int)Size.Medium },
                { "OrganicRepair" , (int)Size.Medium },
                { "Attack", (int)Size.Medium },
                { "Gather" , (int)Size.Medium },
                { "Builder" ,(int)Size.Medium },
                { "Repair", (int)Size.Medium },
                { "Defend", (int)Size.Medium },
                { "PointNav", (int)Size.Medium },
                { "EvadeNav", (int)Size.Medium },
                { "TacticleNav", (int)Size.Medium },
                { "Targeting",(int)Size.Medium }
            };
        }

        public int GetSubset(string fromGroup, int count)
        {
            if (RoleGroups[fromGroup] >= count)
            {
                var t = RoleGroups[fromGroup];
                RoleGroups[fromGroup] = t - count;
                return RoleGroups[fromGroup];
            }

            throw new Exception("Not enough bots in group");

        }
    }

    public enum Size
    {
        Small = 50000,
        Medium = 500000,
        Large = 5000000,
        Massive = 10000000,
        None = 0
    }
}
