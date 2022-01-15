using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon
{
    public class NCluster
    {
        public List<NSwarm> nSwarms { get => new List<NSwarm>(); }

        public int MedicalSwarmSize = 1000000;
        public int FactorySwarmSize = 1000000;
        public int BoomSwarmSize = 0;

        public NCluster()
        {
            for (int i = 0; i < MedicalSwarmSize; i++)
            {
                nSwarms.Add(new MedSwarm());
            }

            for (int i = 0; i < FactorySwarmSize; i++)
            {
                nSwarms.Add(new FactorySwarm());
            }
        }
    }
}
