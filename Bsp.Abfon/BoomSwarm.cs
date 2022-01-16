using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon
{
    public class BoomSwarm : NSwarm
    {
        NRoleComp roleComp;

        public BoomSwarm()
        {
            roleComp = new NRoleComp();
            roleComp.RoleGroups["Attack"] = (int)Size.Large;
            roleComp.RoleGroups["Defend"] = (int)Size.Large;
        }
    }
}
