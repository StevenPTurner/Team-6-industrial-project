using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace IndustrialProject
{
    public class Unknown : InnerType
    {
        // protocol id: 0xfa

        public byte sequenceNumber;
        public byte[] data;

        // parses the Unknown packet data after the protocol id
        public override Packet.ErrorType parseAndCheck(MemoryStream stream)
        {
            if (stream.Position + 1 > stream.Length)
            {
                return Packet.ErrorType.ERROR_NOT_ENOUGH_BYTES;
            }

            this.sequenceNumber = (byte)stream.ReadByte();
            this.data = new byte[stream.Length - 1];
            stream.Read(this.data, 0, (int)stream.Length);

            return Packet.ErrorType.NO_ERROR;
        }
        public override byte getSeqNo()
        {
            return sequenceNumber;
        }
    }
}
