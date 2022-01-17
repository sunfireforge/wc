using System;
using System.Collections.Generic;
using System.Text;
using Bsp.Abfon.Swarms;

namespace Bsp.Abfon.Swarms
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

            if (ce.Item1 == 0)
            {
                return;
            }

            var subset = roleComp.GetSubset("Defend", (int)Size.Small);
            World.SendBuzzyBobble(ce, subset);

        }
    }
}
