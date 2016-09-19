using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialProject
{
    class ErrorChecker
    {
        
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
                return Packet.ErrorType.NO_ERROR;
            } else if(prevSeqNo > seqNo)
            {
                // ERROR
                return Packet.ErrorType.ERROR_OUT_OF_ORDER;
            }

            if(seqDist == 0)
            {
                // DUPLICATE
                return Packet.ErrorType.ERROR_DUPLICATE;
            }

            //Could do it with one packet if we store previous seq no in a packet
            return Packet.ErrorType.NO_ERROR;
        }


        //Checks if Parity or Disconnect errors are highlighted
        public Packet.ErrorType determineFlaggedError(string flaggedError)
        {
            if(flaggedError.Equals("Disconnect"))
            {
                return Packet.ErrorType.ERROR_DISCONNECT;
            }
            else if(flaggedError.Equals("Parity"))
            {
                return Packet.ErrorType.ERROR_PARITY;
            }
            return Packet.ErrorType.NO_ERROR;
        }
    }
}
