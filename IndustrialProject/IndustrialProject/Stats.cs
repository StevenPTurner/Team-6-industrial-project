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
        public int noOfPackets { get; set; }
        public int noOfDataChars { get; set; }
        public double avgPacketRate { get; set; }
        public double avgDataRate { get; set; } 
        public int totalNoOfErrors { get; set; }
        public double avgErrorRate { get; set; }

        public Stats()
        {
            noOfPackets = 0;
            noOfDataChars = 0;
            avgPacketRate = 0.00;
            avgDataRate = 0;
            totalNoOfErrors = 0;
            avgErrorRate = 0.00;
        }

        public void setNumberOfPackets()
        {
            //return this.packets.Count;
            this.noOfPackets = this.packets.Count;
        }

        public void setNumberOfDataCharacters()
        {
           // return this.packets.Select(pkt => pkt.data.Length).Sum();
           this.noOfDataChars = this.packets.Select(pkt => pkt.data.Length).Sum();
        }

        public void setAvgPacketRate()
        {
            IEnumerable<DateTime> e = this.packets.Select(pkt => pkt.timestamp);
            //return e.Count() / (e.Last() - e.First()).TotalSeconds;
            this.avgPacketRate = e.Count() / (e.Last() - e.First()).TotalSeconds;
        }

        public void setAvgDataRate()
        {
            IEnumerable<DateTime> e = this.packets.Select(pkt => pkt.timestamp);
            //return this.noOfDataChars / (e.Last() - e.First()).TotalSeconds;
            this.avgDataRate = this.noOfDataChars / (e.Last() - e.First()).TotalSeconds;
        }

        public void setTotalNoOfErrors()
        {
            int totalNoOfErrors = 0;

            for(int i = 0; i < this.packets.Count; i++)
            {
                if(!this.packets[i].error.Equals("NO_ERROR"))
                {
                    totalNoOfErrors++;
                }
            }

            // return totalErrors;
            this.totalNoOfErrors = totalNoOfErrors;
        }

        public void setAvgErrorRate()
        {
            double avgErrorRate = 0.00;
            //return avgErrorRate;
            this.avgErrorRate = avgErrorRate;
        }
    }
}
