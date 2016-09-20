using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialProject
{
    class Stats
    {
        public int noOfPackets { get; set; }
        public int noOfDataChars { get; set; }
        public double avgPacketRate { get; set; }
        public double avgDataRate { get; set; } 
        public int totalNoOfErrors { get; set; }
        public double avgErrorRate { get; set; }

        public Stats(File file)
        {
            noOfPackets = 0;
            noOfDataChars = 0;
            avgPacketRate = 0.00;
            avgDataRate = 0;
            totalNoOfErrors = 0;
            avgErrorRate = 0.00;

            this.noOfPackets = file.packets.Count;

            if (this.noOfPackets <= 0)
                return;

            Packet firstPacket = file.packets.First();
            Packet lastPacket = file.packets.Last();

            var totalTime = lastPacket.timestamp - firstPacket.timestamp;

            foreach(Packet pkt in file.packets)
            {
                this.noOfDataChars += pkt.data.Length;
                if (pkt.error != Packet.ErrorType.NO_ERROR)
                    this.totalNoOfErrors += 1;
            }

            this.avgPacketRate = this.noOfPackets / totalTime.TotalSeconds;
            this.avgDataRate = this.noOfDataChars / totalTime.TotalSeconds;
            this.avgErrorRate = this.totalNoOfErrors / totalTime.TotalSeconds;
        }
    }
}
