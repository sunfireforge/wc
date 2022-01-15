using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon
{
    public class NCluster
    {
        public List<NSwarm> nSwarms { get => new List<NSwarm>(); }


        public NCluster()
        {
            for (int i = 0; i < 100000000; i++)
            {
                nSwarms.Add(new NSwarm());
            }
        }

    }
}
