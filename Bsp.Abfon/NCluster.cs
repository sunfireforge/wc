using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Bsp.Abfon
{
    public class NCluster
    {
        public List<NSwarm> nSwarms { get => new List<NSwarm>(); }

        public int MedicalSwarmSize = 1000000;
        public int FactorySwarmSize = 1000000;
        public int BoomSwarmSize = 10000;
        public int GuardSwarm = 10000;     
        
        public NCluster()
        {

            do
            {

                for (int i = 0; i < MedicalSwarmSize; i++)
                {
                    nSwarms.Add(new GuardSwarm());
                }


                for (int i = 0; i < MedicalSwarmSize; i++)
                {
                    nSwarms.Add(new BoomSwarm());
                }

                for (int i = 0; i < MedicalSwarmSize; i++)
                {
                    nSwarms.Add(new MedSwarm());
                }

                for (int i = 0; i < FactorySwarmSize; i++)
                {
                    nSwarms.Add(new FactorySwarm());
                }

                Thread.Sleep(TimeSpan.FromMinutes(60));

            } while (true);

        }
    }
}
