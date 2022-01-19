using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon
{
    public class GuardSwarm : NSwarm
    {
        NRoleComp roleComp;

        public GuardSwarm()
        {
            roleComp = new NRoleComp();
            roleComp.RoleGroups["Attack"] = (int)Size.None;
            roleComp.RoleGroups["Defend"] = (int)Size.Massive;
            roleComp.RoleGroups["Repair"] = (int)Size.Large;
            roleComp.RoleGroups["Gather"] = (int)Size.Large;
            roleComp.RoleGroups["Attractive"] = (int)Size.Large;
        }
    }
}
