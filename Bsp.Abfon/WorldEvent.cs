using System;
using System.Collections.Generic;
using System.Text;

namespace Bsp.Abfon
{
    public class WorldEvent
    {
        public string EventType;
        public int TargetId;
        public List<int> RelatedIds = new List<int>();
        public string Message;

        public override string ToString()
        {
            return $"{EventType} : {Message} : {TargetId} -> {string.Join(",",RelatedIds) } ";
        }
    }
}
