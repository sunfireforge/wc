using System;
using System.Collections.Generic;
using Bsp.Abfon.Swarms;

namespace Bsp.Abfon
{
    public class Swarm
    {
        public RoleComp Comp { get => new RoleComp(); }

        protected virtual void Behavior()
        {

        }


        public Swarm()
        {

        }

    }
}
