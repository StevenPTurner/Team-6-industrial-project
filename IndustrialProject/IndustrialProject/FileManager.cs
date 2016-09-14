using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialProject
{
    class FileManager
    {

        //Returns list of packets
        List<String> loadFile(string fileName)
        {
            List<String> packets = new List<String>();

            string[] lines = System.IO.File.ReadAllLines(fileName);

            for(int x = 0; x < lines.Length; x++)
            {
                //Build packet, add to list
            }
     
            return packets;
        }
       
    }

}
