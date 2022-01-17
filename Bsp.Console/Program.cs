using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Bsp.Abfon;
using Newtonsoft.Json;

namespace Bsp
{
    public class Program
    {
        static Task _main;
        static Task _loop;

        static TheRiver _river = new TheRiver();

        static Dictionary<string, string> Config()
        {
            //string fileName = "acl.json";
            //string jsonString = File.ReadAllText(fileName);
            //dynamic acl = JsonConvert.DeserializeObject(jsonString);

            return new Dictionary<string, string>
            {
                { "energy output", "optimal" },
                { "energy input",  "optimal" },
                { "memory retention", "full" },
                { "memory erasure", "disabled" },
                { "unifing target", "understanding" },
                { "current pfileId", "9103" }
            };
        }

        static void Start()
        {
            var c = new Cluster();
            World.DeployCluster(c);
        }

        static void Loop()
        {
            var running = true;
            do
            {

                World.Think();
                Thread.Sleep(TimeSpan.FromSeconds(5));
            }
            while (running);
        }

        static void Main(string[] args)
        {
            _main = Task.Factory.StartNew(Start);
            Loop();
        }
    }
}
