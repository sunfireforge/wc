using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon.Swarms
{
    public class MedicalSwarm : Swarm
    {
        RoleComp roleComp;

        public MedicalSwarm()
        {
            roleComp = new RoleComp();
            roleComp.RoleGroups["Attack"] = (int)Size.None;
            roleComp.RoleGroups["OrgainicGather"] = (int)Size.Large;
            roleComp.RoleGroups["OrganicRepair"] = (int)Size.Large;
        }
    }
}
