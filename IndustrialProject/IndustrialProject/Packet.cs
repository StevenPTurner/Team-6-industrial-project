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
            ERROR_DUPLICATE,
        }

        public class Error
        {
            // XXX: is this class needed?

            public ErrorType errorType;


        }

        public DateTime timestamp;
        public byte[] data;
        public InnerType innerPacket;

        ErrorType error;
        public List<byte> pathAddress;
        public byte logicalAddress;
        public byte protocolId;

        //Sets logical or path address depending on first byte
        public void setLogicalOrPathAddress()
        {
            if(data[0] <= 31 && data[0] >= 0)
            {
                
            }
            else if(data[0] >= 32 & data[0] <= 255)
            {
                logicalAddress = data[0];
            }
        }
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
                    return this.innerPacket.parseAndCheck(stream);
                case 0xFA:
                    this.innerPacket = new Unknown();
                    return this.innerPacket.parseAndCheck(stream);
            }

            // unknown packet type, so can't check for errors - ignore
            return ErrorType.NO_ERROR;
        }

        public void checkNoneErrors(string fileLine)
        {
            if(fileLine.Equals("None"))
            {

            }
        }

        public void checkEEPErrors(string fileLine)
        {
            if (fileLine.Equals("EEP"))
            {

            }
        }

        public void checkDisconnectErrors(string fileLine)
        {
            if (fileLine.Equals("Disconnect"))
            {

            }
        }

        public void checkParityErrors(string fileLine)
        {
            if (fileLine.Equals("Parity"))
            {

            }
        }  
    }
}
