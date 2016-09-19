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
            List<string> packets = new List<String>();
            ErrorChecker ec = new ErrorChecker();
            DateTime date = new DateTime();
            string errorFound = null;
            int port;

            file.filename = fname;

            try
            {
                using (StreamReader sr = new StreamReader(fname))
                {
                    date = DateTime.Parse(sr.ReadLine());
   
                    file.startDate = date;
                    Console.WriteLine('\n');
                    Console.WriteLine("File: " + fname);
                    Console.WriteLine("File Start Date: " + date);

                    port = Convert.ToInt32(sr.ReadLine());
                    file.port = port;

                    Console.WriteLine("Port: " + port + '\n');
                    
                    sr.ReadLine();

                    while (sr.Peek() >= 0)
                    {
                        date = DateTime.Parse(sr.ReadLine());

                        string temp = sr.ReadLine();

                        switch (temp)
                        {

                            case "P":
                                Packet packet = new Packet();

                                packet.timestamp = date; //Set packet timestamp
                                string[] stringBytes = sr.ReadLine().Split(' ');//Splitting string of bytes

                                byte[] byteArray = new byte[stringBytes.Length];

                                for (int i = 0; i < stringBytes.Length; i++)
                                {
                                    //byteList.Add(Convert.ToByte(stringBytes[i], 16));
                                    byteArray[i] = Convert.ToByte(stringBytes[i], 16);
                                }

                                Console.WriteLine("Packet Date: " + date.ToString("dd-MM-yyyy HH:mm:ss:fff"));
                                Console.Write("Packet: ");
                                for (int i = 0; i < byteArray.Length; i++)
                                {
                                    Console.Write(byteArray[i] + " ");
                                }

                                Console.WriteLine('\n');
               
                                packet.data = byteArray; //Set packet bytes

                                temp = sr.ReadLine();

                                if (temp.Equals("None") || temp.Equals("EEP"))
                                {
                                   //None or EEP error detected
                                    packet.error = Packet.ErrorType.ERROR_TRUNCATED; //Adding error to packet
                                }

                                file.addPacket(packet);
                                sr.ReadLine();
                                break;
                            case "E":
                                Console.WriteLine("Error (E) At: " + date.ToString("dd-MM-yyyy HH:mm:ss:fff"));
                                temp = sr.ReadLine();

                                //Return error
                                ec.determineFlaggedError(temp);

                                sr.ReadLine();
                                break;
                            default:
                                Console.WriteLine('\n' + "File end date: " + date.ToString("dd-MM-yyyy HH:mm:ss:fff"));
                                sr.ReadLine();
                                break;
                        }
                    }

                }

            }
            catch (Exception E)
            {
                errorFound = E.ToString();
            }

            if (errorFound == null)
            {
               // Console.WriteLine("File found");
            }
            else
            {
                Console.WriteLine("File not found");
            }

            //Stats stats = new Stats();
            file. stats.packets = file.packets;

            file.stats.setNumberOfPackets();
            file.stats.setNumberOfDataCharacters();
            file.stats.setAvgPacketRate();
            file.stats.setAvgDataRate();     
                
            Console.WriteLine("No of packets: " + file.stats.noOfPackets);
            Console.WriteLine("No. of data chars: " + file.stats.noOfDataChars);
            Console.WriteLine("Avg. Packet Rate: " + file.stats.avgPacketRate);
            Console.WriteLine("Avg. Data Rate: " + file.stats.avgDataRate);

            return file;
        }

        public Packet lastPacket()
        {
            Packet packet = new IndustrialProject.Packet();

            return packet;
        }
    }
}
