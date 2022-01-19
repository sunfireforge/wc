using System;
using System.Collections.Generic;


namespace Bsp.Abfon
{
    public class World
    {

        private static List<Angel> ActiveAngels = new List<Angel>();
        private static List<Cluster> ActiveClusters = new List<Cluster>();
        
        public static AngelMaterializer Generator = new AngelMaterializer();

        public static object Thread { get; set; }

        public static void Think()
        {
            GetNextCrimeEvent(CrimeLevel.Felony);
        }

        public static WorldEvent GetNextCrimeEvent(CrimeLevel level)
        {
            var r = new Random((int)DateTime.Now.Second);
            var seattlePopulation = 1000000;
            var e = new WorldEvent();


            e.EventType = "crime_event";
            e.TargetId = r.Next(1, seattlePopulation);
            e.RelatedIds.Add(r.Next(1, seattlePopulation));

            e.Message = "ce from sim";


            if (level == CrimeLevel.Felony)
            {
                Console.WriteLine("new crime event (sim):  -> {0}", e);
                return e;
            }

            return null;
        }

        public static void DeployCluster(Cluster cluster)
        {
            ActiveClusters.Add(cluster);
        }

        public static void SendAngel(int target, int density )
        {
            var b = new Angel(density);

            ActiveAngels.Add(b);
        }
    }

    public enum CrimeLevel
    {
        Victimless,
        Misdemenor,
        Felony
    }


}
