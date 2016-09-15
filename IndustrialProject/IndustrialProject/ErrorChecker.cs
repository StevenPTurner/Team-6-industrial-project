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

        public Packet.ErrorType determineError()//pass file as a parameter - need the list of packets?
        {
            //Could do it with one packet if we store previous seq no in a packet
            return Packet.ErrorType.NO_ERROR;
        }
    }
}
