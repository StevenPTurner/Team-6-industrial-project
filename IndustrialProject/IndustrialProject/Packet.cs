using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IndustrialProject
{
    public class Packet
    {
        public enum ErrorType
        {
            //XXX: Is this a good place for this enum - define it in File instead?
            NO_ERROR,
            ERROR_TRUNCATED,
            ERROR_DISCONNECT,
            ERROR_PARITY,
            ERROR_HEADER_CRC,
            ERROR_BODY_CRC,
            ERROR_OUT_OF_ORDER,
            ERROR_BAD_PATH,
            ERROR_TOO_MANY_BYTES,
            ERROR_NOT_ENOUGH_BYTES,
            ERROR_DUPLICATE,
        }

        public class Error
        {
            // XXX: is this class needed?

            public string rawError;
            public ErrorType errorType;
            public DateTime timestamp;

            public Error(string rawError, DateTime timestamp)
            {
                this.rawError = rawError;
                this.timestamp = timestamp;
                this.errorType = ErrorChecker.determineFlaggedError(this.rawError);
            }
        }

        public DateTime timestamp;
        public byte[] data;
        public string epm;

        public InnerType innerPacket;

        public Error errorPacket;
        public ErrorType error;

        public List<byte> pathAddress;
        public byte logicalAddress;
        public byte protocolId;

        public Packet()
        {
            this.pathAddress = new List<byte>();
        }

        public void loadDataAndEndMarker(byte[] data, string epm)
        {
            this.data = data;
            this.epm = epm;
        }

        public void setError(ErrorType error)
        {
            this.error = error;
        }

        // loads and parses the packet bytes
        public ErrorType findError()
        {
            MemoryStream stream = new MemoryStream(this.data);

            do
            {
                if(stream.Position + 2 >= stream.Length)
                {
                    return ErrorType.ERROR_BAD_PATH;
                }

                this.pathAddress.Add((byte)stream.ReadByte());
                this.logicalAddress = this.pathAddress[this.pathAddress.Count - 1];
                this.pathAddress.RemoveAt(this.pathAddress.Count - 1);
            } while (this.logicalAddress < 32);

            this.protocolId = (byte)stream.ReadByte();

            switch(this.protocolId)
            {
                case 0x01:
                    this.innerPacket = new RMAP();
                    return this.innerPacket.parseAndCheck(stream);
                case 0xFA:
                    this.innerPacket = new Unknown();
                    return this.innerPacket.parseAndCheck(stream);
            }

            // unknown packet type, so can't check for errors - ignore
            return ErrorType.NO_ERROR;
        }
    }
}
