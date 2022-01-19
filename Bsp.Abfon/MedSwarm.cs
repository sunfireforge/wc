using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon
{
    public class MedSwarm : Swarm
    {
        RoleComp roleComp;

        public MedSwarm()
        {
            roleComp = new RoleComp();
            roleComp.RoleGroups["Attack"] = (int)Size.None;
            roleComp.RoleGroups["OrgainicGather"] = (int)Size.Large;
            roleComp.RoleGroups["OrganicRepair"] = (int)Size.Large;
        }

    }
}
