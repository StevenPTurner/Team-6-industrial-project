using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialProject
{
    public class Packet
    {
        public enum ErrorType
        {
            ERROR_DISCONNECT,
            ERROR_PARITY,
            ERROR_CRC,
            ERROR_OUT_OF_ORDER,
        }

        public class Error
        {
            public ErrorType errorType;
        }

        public DateTime timestamp;
        public byte[] data;
        public InnerType innerPacket;
        public List<Error> errors;
    }
}
