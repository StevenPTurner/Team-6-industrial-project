﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IndustrialProject
{
    public abstract class InnerType
    {
        public abstract Packet.ErrorType parseAndCheck(MemoryStream stream);

        public abstract int getSeqNo();
        public abstract int getMaxSeqNo();
    }
}
