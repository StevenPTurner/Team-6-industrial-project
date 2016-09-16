using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialProject
{
    //Manages file handling
    class FileManager
    {

        //Returns list of packets
        public File loadAndParseFile(string fname) //Note: Set as string temporarily until File class is built.
        {

            File file = new IndustrialProject.File();
            file.filename = fname;
            
            List<string> packets = new List<String>();
            string errorFound = null;
            ErrorChecker ec = new ErrorChecker();
            DateTime date = new DateTime();
            int port;

            try
            {
                using (StreamReader sr = new StreamReader(fname))
                {
                    date = DateTime.Parse(sr.ReadLine());
                    //date = Convert.ToDateTime(sr.ReadLine());
                    Console.WriteLine(date);

                    //Console.WriteLine(date.ToString("dd-MM-yyyy hh:mm:ss.fff"));
                    file.startDate = date;

                    port = Convert.ToInt32(sr.ReadLine());
                    file.port = port;

                    Console.WriteLine("The port is: " + port);
                    
                    sr.ReadLine();

                    while (sr.Peek() >= 0)
                    {

                       // Console.WriteLine("Line: " + sr.ReadLine());
                        Packet packet = new Packet();

                        date = DateTime.Parse(sr.ReadLine());
                        Console.WriteLine("Date is:" + date);
                       // date = Convert.ToDateTime(sr.ReadLine());
                        
                       // Console.WriteLine(date.ToString("dd-MM-yyyy hh:mm:ss.fff"));
                        //Console.WriteLine(date);

                        packet.timestamp = date; //Set packet timestamp

                        //Console.WriteLine("Was trying to convert...." + sr.ReadLine());
                        //Add date (Packet date)
                        string temp = sr.ReadLine();

                        switch (temp)
                        {

                            case "P":
                                //sr.ReadLine() --- Add packet
                                string[] stringBytes = sr.ReadLine().Split(' ');
                                //List<byte> byteList = new List<byte>();

                                Console.WriteLine("P found");

                                byte[] byteArray = new byte[stringBytes.Length];

                                for (int i = 0; i < stringBytes.Length; i++)
                                {
                                    //byteList.Add(Convert.ToByte(stringBytes[i], 16));
                                    byteArray[i] = Convert.ToByte(stringBytes[i], 16);
                                }

                                //Handling logical address/path address in packet class?

                                packet.data = byteArray; //Set packet bytes

                                temp = sr.ReadLine();

                                if (temp.Equals("None") || temp.Equals("EEP"))
                                {
                                    packet.error = Packet.ErrorType.ERROR_TRUNCATED; //Adding error to packet
                                }

                                file.addPacket(packet);
                                //sr.ReadLine(); //Skip blank line
                                sr.ReadLine(); //Skips empty line
                                break;
                            case "E":
                                //sr.ReadLine(); // Will show us whether disconnect or parity error
                                temp = sr.ReadLine();

                                if (temp.Equals("Disconnect"))
                                {
                                    //Add disconnect to last packet 
                                    packet.error = Packet.ErrorType.ERROR_DISCONNECT;
                                }
                                else if(temp.Equals("Parity"))
                                {
                                    //Add parity to last packet 
                                    packet.error = Packet.ErrorType.ERROR_PARITY;
                                }

                                sr.ReadLine(); //Skips empty line
                                date = Convert.ToDateTime(sr.ReadLine());
                                //date.AddMilliseconds();
                                Console.WriteLine("E was found");
                                Console.WriteLine("End of file: " + date);
                                file.endDate = date;
                                //Add error.
                                break;
                            default:
                                break;
                        }

                       
                   }

                    //while(sr.ReadLine() != null)
                    //{
                    // Console.WriteLine("Line here");
                    //}
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

            Stats stats = new Stats();
            stats.packets = file.packets;

           
           Console.WriteLine("No of packets: " + stats.getNumberOfPackets());
            Console.WriteLine("No. of data chars: " + stats.getNumberOfDataCharacters());
           // Console.WriteLine("Avg. Data chars: " + stats.getAvgDataRate());

            return file;
        }

        public Packet lastPacket()
        {
            Packet packet = new IndustrialProject.Packet();




            return packet;
        }
    }
}
