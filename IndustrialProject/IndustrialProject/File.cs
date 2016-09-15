using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialProject
{
    class File
    {
        String filename { set; get; }
        DateTime startDate { set; get; }
        int port { set; get; }
        public List<Packet> packets { get; private set; }
        Stats stats;

        public File()
        {
            this.packets = new List<Packet>();
            this.stats = new Stats(this);
        }

        public void addPacket(Packet packetToAdd)
        {
            this.packets.Add(packetToAdd);
        }
    }
}
