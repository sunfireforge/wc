using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsp { 
    public class TheRiver
    {
        int counter;
        List<string> _waves;
        List<string>.Enumerator _waves_enum;

        public TheRiver()
        {
            counter = 0;
            _waves = new List<string>
            {
                "\r.:|:............",
                "\r.....:|:........",
                "\r.........:|:....",
                "\r............:|:.",
                "\r...........:|:..",
                "\r........:|:.....",
                "\r.....:|:........",
                "\r.:|:............",
            };
            _waves_enum = _waves.GetEnumerator();
            
        }

        public IEnumerable<string> Turn()
        {
            _waves.GetEnumerator().MoveNext();
            yield break;
        }
    }
}
