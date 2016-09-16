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
            ERROR_DISCONNECT,
            ERROR_PARITY,
            ERROR_HEADER_CRC,
            ERROR_BODY_CRC,
            ERROR_OUT_OF_ORDER,
            ERROR_BAD_PATH,
            ERROR_TOO_MANY_BYTES,
            ERROR_NOT_ENOUGH_BYTES,
        }

        public class Error
        {
            // XXX: is this class needed?

            public ErrorType errorType;
        }

        public DateTime timestamp;
        public byte[] data;
        public InnerType innerPacket;
        public byte prevSeqNo; //Dunno how to get that, but would be helpful to sort the sequence errors
        public byte seqNo;
        //public List<Error> errors;
        ErrorType error;
        public List<byte> pathAddress;
        public byte logicalAddress;
        public byte protocolId;

        // loads and parses the packet bytes
        public ErrorType loadAndCheck(byte[] data)
        {
            this.data = data;
            
            MemoryStream stream = new MemoryStream(data);

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
                    this.seqNo = this.innerPacket.getSeqNo();
                    return this.innerPacket.parseAndCheck(stream);
                case 0xFA:
                    this.innerPacket = new Unknown();
                    this.seqNo = this.innerPacket.getSeqNo();
                    return this.innerPacket.parseAndCheck(stream);
            }

            // unknown packet type, so can't check for errors - ignore
            return ErrorType.NO_ERROR;
        }
    }
}
