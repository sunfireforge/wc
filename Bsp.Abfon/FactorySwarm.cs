using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon
{
    public class FactorySwarm:NSwarm
    {

        NRoleComp roleComp;

        public FactorySwarm()
        {
            roleComp = new NRoleComp
            {
                Attack = Size.None,
                Defend = Size.Medium,
                Gather = Size.Massive,
                Builder = Size.Massive,
                Repair = Size.Massive

            };
        }
    }
}
