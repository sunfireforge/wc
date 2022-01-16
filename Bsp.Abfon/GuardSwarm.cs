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
            roleComp = new NRoleComp
            {
                Attack = Size.Small,
                Defend = Size.Massive,
            };
        }
    }
}
