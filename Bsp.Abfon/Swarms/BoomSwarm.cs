using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon.Swarms
{
    public class BoomSwarm : Swarm
    {
        RoleComp roleComp;

        public BoomSwarm()
        {
            roleComp = new RoleComp();
            roleComp.RoleGroups["Attack"] = (int)Size.Large;
            roleComp.RoleGroups["Defend"] = (int)Size.Large;
        }
    }
}
