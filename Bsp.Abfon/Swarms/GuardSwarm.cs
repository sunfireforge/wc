using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon.Swarms
{
    public class GuardSwarm : Swarm
    {
        RoleComp roleComp;

        public GuardSwarm()
        {
            roleComp = new RoleComp();
            roleComp.RoleGroups["Attack"] = (int)Size.None;
            roleComp.RoleGroups["Defend"] = (int)Size.Massive;
            roleComp.RoleGroups["Repair"] = (int)Size.Large;
            roleComp.RoleGroups["Gather"] = (int)Size.Large;

        }

        protected override void Behavior()
        {
            base.Behavior();
        }


    }
}
