﻿using System;
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

        public string determineError(string packet)
        {
            //Work on packet.
            return null;
        }
    }
}