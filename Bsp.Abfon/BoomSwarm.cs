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
            roleComp = new NRoleComp
            {
                Attack = Size.Large,
                Defend = Size.Large,
            };
        }
    }
}
