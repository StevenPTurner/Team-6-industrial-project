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

        public double getAvgDataRate()
        {
            IEnumerable<DateTime> e = this.packets.Select(pkt => pkt.timestamp);
            return this.getNumberOfDataCharacters() / (e.Last() - e.First()).TotalSeconds;
        }

        public int getTotalNoOfErrors()
        {
            int totalErrors = 0;

            for(int i = 0; i < this.packets.Count; i++)
            {
                if(!this.packets[i].error.Equals("NO_ERROR"))
                {
                    totalErrors++;
                }
            }

            return totalErrors;
        }

        public double getAvgErrorRate()
        {
            double avgErrorRate = 0.00;
            return avgErrorRate;
        }
    }
}
