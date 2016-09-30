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
            NO_ERROR = 1 << 0,
            ERROR_TRUNCATED = 1 << 1,
            ERROR_DISCONNECT = 1 << 2,
            ERROR_PARITY = 1 << 3,
            ERROR_HEADER_CRC = 1 << 4,
            ERROR_BODY_CRC = 1 << 5,
            ERROR_OUT_OF_ORDER = 1 << 6,
            ERROR_BAD_PATH = 1 << 7,
            ERROR_TOO_MANY_BYTES = 1 << 8,
            ERROR_NOT_ENOUGH_BYTES = 1 << 9,
            ERROR_DUPLICATE = 1 << 10,
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

        public string displayDate { set; get; }
        public string displayTime { get; set; }
        public string displayData { get; set; }
        public string displayErrorType { set; get; }
        public string displayPathAddress { set; get; }
        public string displayLogicalAddress { set; get; }
        public string displayProtocolId { set; get; }
        

        public InnerType innerPacket;

        public Error errorPacket;
        public ErrorType error;

        public List<byte> pathAddress;
        public byte logicalAddress;
        public byte protocolId;

        public Packet()
        {
            this.pathAddress = new List<byte>();
            this.error = ErrorType.NO_ERROR;
        }

        public void loadDataAndEndMarker(byte[] data, string epm)
        {
            this.data = data;
            this.epm = epm;
            
            // CHECK FOR END OF MARKER ERROR

            if (this.epm == "EEP" || this.epm == "None")
            {
                this.error = Packet.ErrorType.ERROR_TRUNCATED;
                displayErrorType = error.ToString();
            }
            else if (this.epm != "EOP")
            {
                // FIX: ARGH... undefined error
                throw new Exception("ARGH...");
            }
            MemoryStream stream = new MemoryStream(this.data);

            do
            {
                if (stream.Position + 2 >= stream.Length)
                {
                    return;
                }

                this.pathAddress.Add((byte)stream.ReadByte());
                this.logicalAddress = this.pathAddress[this.pathAddress.Count - 1];

                
            } while (this.logicalAddress < 32);

            this.pathAddress.RemoveAt(this.pathAddress.Count - 1);
            this.protocolId = (byte)stream.ReadByte();
        }



        public void setError(ErrorType error)
        {
            if (error == ErrorType.NO_ERROR)
                return;

            this.error = error;
            displayErrorType = error.ToString();
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
