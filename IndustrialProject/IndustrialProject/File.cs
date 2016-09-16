using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialProject
{
    class File
    {
        public String filename { set; get; }
        public DateTime endDate { set; get;  }
        public DateTime startDate { set; get; }
        public int port { set; get; }
        public List<Packet> packets { get; private set; }
        public Stats stats;

        public File()
        {
            this.packets = new List<Packet>();
            this.stats = new Stats();
        }

        public void addPacket(Packet packetToAdd)
        {
            this.packets.Add(packetToAdd);
        }
    }
}
