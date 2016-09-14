using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialProject
{
    //Manages file handling
    class FileManager
    {

        //Returns list of packets
        List<string> loadFile(string fileName) //Note: Set as string temporarily until Packet class is built.
        {
            List<string> packets = new List<String>();
            string errorFound = null;
            ErrorChecker ec = new ErrorChecker();

            try
            {
                string[] lines = System.IO.File.ReadAllLines(fileName);

                Console.WriteLine("Date: " + lines[0]);
                Console.WriteLine("Port No: " + lines[1]);

                for (int x = 3; x < lines.Length; x = x + 5)
                {
                    //Build packet, add to list
                    Console.WriteLine("Interested: " + lines[x]);
                    Console.WriteLine("Interested: " + lines[x + 1]);

                    //check error @ lines[x+1]

                    //Need to check data for errors such as crc

                    if (ec.errorMarker(lines[x + 1]))
                    {
                        //lines[x] = timestamp
                      
                        //string errorType = ... Pass last packet
                        if (lines[x + 2].Equals("Parity"))
                        {
                            //Parity error
                        }
                        else if (lines[x + 2].Equals("Disconnect"))
                        {
                            //Disconnect
                        }
                    }

                    Console.WriteLine("Interested: " + lines[x + 2]);
                    Console.WriteLine("Interested: " + lines[x + 3]);
                }
            }
            catch (Exception E)
            {
                errorFound = E.ToString();
            }

            if (errorFound == null)
            {
                Console.WriteLine("File found");
            }
            else
            {
                Console.WriteLine("File not found");
            }

            return packets;
        }  
    }
}
