using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon
{
    public class MarkerSwarm : NSwarm
    {
        NRoleComp roleComp;

        public MarkerSwarm()
        {
            roleComp = new NRoleComp();
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
