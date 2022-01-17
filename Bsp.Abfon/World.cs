using System;
using System.Collections.Generic;


namespace Bsp.Abfon
{
    public class World
    {

        private static List<BuzzyBobble> _activeBobble = new List<BuzzyBobble>();
        private static List<Cluster> _activeClusters = new List<Cluster>();
        public static BuzzyBobbleGenerator _generator = new BuzzyBobbleGenerator();


        public static Tuple<int, int> GetNextCrimeEvent(CrimeLevel level)
        {
            var r = new Random((int)DateTime.Now.Second);
            var seattlePopulation = 1000000;

            if (level == CrimeLevel.Felony)
            {
                return new Tuple<int, int>(r.Next(1, seattlePopulation), r.Next(1, seattlePopulation));
            }

            return new Tuple<int, int>(0, 0);
        }

        public static void DeployCluster(Cluster cluster)
        {
            _activeClusters.Add(cluster);
        }

        public static void SendBuzzyBobble(Tuple<int, int> ts, int count )
        {
            var b = new BuzzyBobble(count);

            _activeBobble.Add(b);
        }
    }

    public enum CrimeLevel
    {
        Victimless,
        Misdemenor,
        Felony
    }


}
