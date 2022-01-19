using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon
{
    public class MarkerSwarm : Swarm
    {
        RoleComp roleComp;

        public MarkerSwarm()
        {
            roleComp = new RoleComp();
            roleComp.RoleGroups["Attack"] = (int)Size.None;
            roleComp.RoleGroups["Defend"] = (int)Size.Massive;
        }

        protected override void Behavior()
        {
            var ce = World.GetNextCrimeEvent(CrimeLevel.Felony);

            if (ce.TargetId == 0)
            {
                return;
            }

            var subset = roleComp.GetSubset("Defend", (int)Size.Small);
            World.SendAngel(ce.TargetId, subset);

        }
    }
}
