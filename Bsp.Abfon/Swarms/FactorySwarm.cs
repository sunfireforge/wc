using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon.Swarms
{
    public class FactorySwarm : Swarm
    {

        RoleComp roleComp;

        public FactorySwarm()
        {
            roleComp = new RoleComp();
            roleComp.RoleGroups["Attack"] = (int)Size.None;
            roleComp.RoleGroups["Defend"] = (int)Size.Massive;
            roleComp.RoleGroups["Gather"] = (int)Size.Large;
            roleComp.RoleGroups["Builder"] = (int)Size.Large;
            roleComp.RoleGroups["Repair"] = (int)Size.Large;

        }
    }
}
