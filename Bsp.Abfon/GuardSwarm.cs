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
                Attack = Size.None,
                Defend = Size.Massive,
                Repair = Size.Large,
                Gather = Size.Large
                
            };
        }
    }
}
