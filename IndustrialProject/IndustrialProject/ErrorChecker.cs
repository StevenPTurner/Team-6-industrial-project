using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialProject
{
    class ErrorChecker
    {
        public bool errorMarker(string line)
        {

            switch (line)
            {
                case "P":
                    break;
                case "E":
                    return true;
                default:
                    break;
            }
            return false;
        }
        
        public Packet.ErrorType determineError(Tuple<Packet, Packet> packets)//pass file as a parameter - need the list of packets?
        {
            // the max jump up in sequence number
            const int WRAP_THRESHOLD = 5;

            int prevSeqNo = packets.Item1.innerPacket.getSeqNo();
            int seqNo = packets.Item2.innerPacket.getSeqNo();

            int seqDist = Math.Abs(seqNo - prevSeqNo);

            if(seqDist > packets.Item2.innerPacket.getMaxSeqNo() - WRAP_THRESHOLD && prevSeqNo > seqNo)
            {
                // WRAPPED
            } else if(prevSeqNo > seqNo)
            {
                // ERROR
            }

            //Could do it with one packet if we store previous seq no in a packet
            return Packet.ErrorType.NO_ERROR;
        }
    }
}
