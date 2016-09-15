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
        public void parse(MemoryStream stream)
        {
            this.sequenceNumber = (byte)stream.ReadByte();
            this.data = new byte[stream.Length - 1];
            stream.Read(this.data, 0, (int)stream.Length);
        }
    }
}
