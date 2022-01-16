using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bsp.Abfon;

namespace Bsp.Console
{
    public class Program
    {

        static Dictionary<string, string> Config()
        {
            return new Dictionary<string, string>
            {
                { "energy output", "optimal" },
                { "energy input",  "optimal" },
                { "memory retention", "full" },
                { "memory erasure", "disabled" },
                { "unifing target", "understanding" },
                { "current pfileId", "00000" }
            };

        }

        static void Start()
        {
            var c = new NCluster();

            World.DeployCluster(c);

        }


        static void Main(string[] args)
        {
            var t = Task.Run(Start);

            t.Wait();
        }
    }
}
