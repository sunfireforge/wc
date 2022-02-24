using System;
using System.Collections.Generic;


namespace Bsp.Abfon
{
    public class World
    {

        private static List<Angel> ActiveAngels = new List<Angel>();
        private static List<Murry856> ActiveMurrys = new List<Murry856>();
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

        public static void SendAngel(int target, int density)
        {
            var b = new Angel(new Dictionary<Mode, int> {
                {Mode.Build, 21 },
                {Mode.Search, 21 },
                {Mode.Repair, 21 },
                {Mode.Remind, 21 },
                {Mode.Clean, 21}
            });

            ActiveAngels.Add(b);
        }

        public static void DeployMurry856(int location)
        {
            ActiveMurrys.Add(new Murry856() { location = "1" });
            ActiveMurrys.Add(new Murry856() { location = "2" });
        }
    }

    public enum CrimeLevel
    {
        Victimless,
        Misdemenor,
        Felony
    }
}
