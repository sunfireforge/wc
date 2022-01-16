using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon
{
    public class FactorySwarm : NSwarm
    {

        NRoleComp roleComp;

        public FactorySwarm()
        {
            roleComp = new NRoleComp();
            roleComp.RoleGroups["Attack"] = (int)Size.None;
            roleComp.RoleGroups["Defend"] = (int)Size.Massive;
            roleComp.RoleGroups["Gather"] = (int)Size.Large;
            roleComp.RoleGroups["Builder"] = (int)Size.Large;
            roleComp.RoleGroups["Repair"] = (int)Size.Large;

        }
    }
}
