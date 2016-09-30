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
        public int outOfSeqErrs { get; private set; }
        public int tooManyBytesErrs { get; private set; }
        public int notEnoughBytesErrs { get; private set; }
        public int bodyCRCErrs { get; private set; }
        public int headCRCErrs { get; private set; }
        public int parityErrs { get; private set;  }
        public int eepAndTimeoutErrs { get; private set; }
        public int errDuplicateErrs { get; private set;  }
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
                    notEnoughBytesErrs++;
                    break;
                case Packet.ErrorType.ERROR_TOO_MANY_BYTES:
                    tooManyBytesErrs++;
                    break;
                case Packet.ErrorType.ERROR_BODY_CRC:
                    bodyCRCErrs++;
                    break;
                case Packet.ErrorType.ERROR_HEADER_CRC:
                    headCRCErrs++;
                    break;
                case Packet.ErrorType.ERROR_TRUNCATED:
                    eepAndTimeoutErrs++;
                    break;
                case Packet.ErrorType.ERROR_PARITY:
                    parityErrs++;
                    break;
                case Packet.ErrorType.ERROR_DUPLICATE:
                    errDuplicateErrs++;
                    break;
                default:
                    Console.WriteLine("No error - cannot increment...");
                    break;
            }
        }
    }
}
