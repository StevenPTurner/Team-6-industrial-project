using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialProject
{
    class GraphCalculations
    {
        public double calcPacketTimeDif(DateTime date1, DateTime date2)
        {
            double timeDifference = 0;
            return timeDifference = (date2 - date1).TotalSeconds;
        }

        public void doStuff()
        {
            //Console.WriteLine("Element: " + element);
        }
    }
}
