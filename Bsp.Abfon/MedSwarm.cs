using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon
{
    public class MedSwarm : NSwarm
    {
        NRoleComp roleComp;

        public MedSwarm()
        {
            roleComp = new NRoleComp
            {
                Attack = Size.None,
                OrgainicGather = Size.Large,
                OrganicRepair = Size.Large
            };
        }

    }
}
