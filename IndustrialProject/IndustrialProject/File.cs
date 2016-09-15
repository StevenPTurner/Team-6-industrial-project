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
        List<Packet> packet;
        Stats stats;

        public File()
        {
            packet = new List<Packet>();
        }

        public void addPacket(Packet packetToAdd)
        {
            packet.Add(packetToAdd);
        }
    }
}
