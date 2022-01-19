using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Bsp.Abfon.Swarms;

namespace Bsp.Abfon
{
    public class Cluster
    {
        //TODO: Refactor
        public List<Swarm> nSwarms { get => new List<Swarm>(); }

        public int MedicalSwarmSize = 1000000;
        public int FactorySwarmSize = 1000000;
        public int MarkerSwarmSize = 1000;
        public int BoomSwarmSize = 10000;
        public int GuardSwarm = 100000;     
        
        public Cluster()
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
                    nSwarms.Add(new MedicalSwarm());
                }

                for (int i = 0; i < FactorySwarmSize; i++)
                {
                    nSwarms.Add(new FactorySwarm());
                }

                Thread.Sleep(TimeSpan.FromMinutes(60));

                World.DeployCluster(this);

            } while (true);
        }

    }
}
