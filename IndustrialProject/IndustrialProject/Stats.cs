using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialProject
{
    class Stats
    {
        private File file;

        public Stats(File file)
        {
            this.file = file;
        }

        int getNumberOfPackets()
        {
            return this.file.packets.Count;
        }

        int getNumberOfDataCharacters()
        {
            return this.file.packets.Select(pkt => pkt.data.Length).Sum();
        }

        double getAvgDataRate()
        {
            IEnumerable<DateTime> e = this.file.packets.Select(pkt => pkt.timestamp);
            return e.Count() / (e.Last() - e.First()).TotalSeconds;
        }
    }
}
