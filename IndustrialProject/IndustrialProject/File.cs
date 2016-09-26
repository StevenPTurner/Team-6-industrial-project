using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialProject
{
    public class File
    {
        public String filename { set; get; }
        public DateTime endDate { set; get;  }
        public DateTime startDate { set; get; }
        public int port { set; get; }
        public List<Packet> packets { get; private set; }
        public int outOfSeqErrs { get; private set;}
        public int dataErrs { get; private set; }
        public int crcErrs { get; private set; }
        public int parityErrs { get; private set;  }
        public int eepAndTimeoutErrs { get; private set; }
        public Stats stats;

        public File()
        {
            this.packets = new List<Packet>();
        }

        public void addPacket(Packet packetToAdd)
        {
            this.packets.Add(packetToAdd);
        }

        public void incrementErrCounts(Packet.ErrorType errorType)
        {
            switch (errorType)
            {
                case Packet.ErrorType.ERROR_OUT_OF_ORDER:
                    outOfSeqErrs++;
                    break;
                case Packet.ErrorType.ERROR_NOT_ENOUGH_BYTES:
                case Packet.ErrorType.ERROR_TOO_MANY_BYTES:
                    dataErrs++;
                    break;
                case Packet.ErrorType.ERROR_BODY_CRC:
                case Packet.ErrorType.ERROR_HEADER_CRC:
                    crcErrs++;
                    break;
                case Packet.ErrorType.ERROR_TRUNCATED:
                    eepAndTimeoutErrs++;
                    break;
                case Packet.ErrorType.ERROR_PARITY:
                    parityErrs++;
                    break;
                default:
                    Console.WriteLine("No error - cannot increment...");
                    break;
            }
        }
    }
}
