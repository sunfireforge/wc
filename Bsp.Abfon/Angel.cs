using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon
{
    public class Angel
    {

        public string AdminOverride = "not i";

        public float signal_a = 1.0f;
        public float signal_z = 0.1f;
        
        
        private Dictionary<Mode, int> _mode;

        public Angel()
        {

        }


        public Angel(Dictionary<Mode, int> mode)
        {
            _mode = mode;
        }
    }

    [Flags]

    public enum Mode
    {
        Clean,
        Search,
        Repair,
        Build,
        Remind
    }
}
