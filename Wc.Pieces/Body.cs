using System;
using System.Linq;
using System.Collections.Generic;

namespace Wc.Pieces
{
    public class Body : PieceBase
    {
        public static string DndMessage { get; internal set; }

        public List<Mind> MindSet { get; private set; }

        public List<Heart> HeartSet { get; private set; }
        
        public List<Heart> HeartsWishing { get; private set; }

        public List<Heart> HeartsTurnedOff { get; private set; }

        public List<Soul> SoulSet { get; private set; }

        public List<Spirit> SpiritSet { get; private set; }

        public override void Think()
        {

            base.Think();
        }
    }
}
