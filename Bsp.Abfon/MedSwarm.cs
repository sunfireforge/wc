using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon
{
    public class MedSwarm : NSwarm
    {
        NRoleComp roleComp;

        public MedSwarm()
        {
            roleComp = new NRoleComp();
            roleComp.RoleGroups["Attack"] = (int)Size.None;
            roleComp.RoleGroups["OrgainicGather"] = (int)Size.Large;
            roleComp.RoleGroups["OrganicRepair"] = (int)Size.Large;
        }

    }
}
