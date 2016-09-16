using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialProject
{
    class Stats
    {
        public List<Packet> packets { get; set; }

        public Stats()
        {
            //this.packets = packets;
        }

        

        public int getNumberOfPackets()
        {
            return this.packets.Count;
        }

        public int getNumberOfDataCharacters()
        {
            return this.packets.Select(pkt => pkt.data.Length).Sum();
        }

        public double getAvgPacketRate()
        {
            IEnumerable<DateTime> e = this.packets.Select(pkt => pkt.timestamp);
            return e.Count() / (e.Last() - e.First()).TotalSeconds;
        }
    }
}
