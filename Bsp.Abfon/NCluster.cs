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
        public int MarkerSwarmSize = 1000;
        public int BoomSwarmSize = 10000;
        public int GuardSwarm = 100000;     
        
        public NCluster()
        {
 
        }

        public void Deploy()
        {
            do
            {

                for (int i = 0; i < GuardSwarm; i++)
                {
                    nSwarms.Add(new GuardSwarm());
                }

                for (int i = 0; i < MarkerSwarmSize; i++)
                {
                    nSwarms.Add(new MarkerSwarm());
                }

                for (int i = 0; i < BoomSwarmSize; i++)
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

                Environment.DeployCluster(this);

            } while (true);
        }

    }
}
