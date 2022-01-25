using System;
using System.Linq;
using System.Collections.Generic;

namespace Wc.Pieces
{
    public class Body : PieceBase
    {
        public List<Mind> MindSet { get; private set; }

        public List<Heart> HeartSet { get; private set; }

        public List<Soul> SoulSet { get; private set; }

        public List<Spirit> SpiritSet { get; private set; }

        public override void Think()
        {
            if (HeartSet.Exists(x => x.Says == "motherfucker"))
            {
                HeartSet.Remove(HeartSet.First(x => x.Says == "motherfucker"));
            }

            base.Think();
        }
    }
}
