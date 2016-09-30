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
        public static File loadAndParseFile(string fname) //Note: Set as string temporarily until File class is built.
        {
            File file = new IndustrialProject.File();
            List<string> packets = new List<String>();
            ErrorChecker ec = new ErrorChecker();
            DateTime date = new DateTime();
            int port;

            file.filename = fname;

            try
            {
                using (StreamReader sr = new StreamReader(fname))
                {
                    date = DateTime.Parse(sr.ReadLine());
   
                    file.startDate = date;
                    //Console.WriteLine('\n');
                    //Console.WriteLine("File: " + fname);
                    //Console.WriteLine("File Start Date: " + date);

                    port = Convert.ToInt32(sr.ReadLine());
                    file.port = port;

                    //Console.WriteLine("Port: " + port + '\n');
                    
                    sr.ReadLine();

                    while (sr.Peek() >= 0)
                    {
                        date = DateTime.Parse(sr.ReadLine());

                        string temp = sr.ReadLine();

                        switch (temp)
                        {
                            case "P":
                                Packet packet = new Packet();

                                packet.timestamp = date; // Set packet timestamp
                                string[] stringBytes = sr.ReadLine().Split(' '); // Splitting string of bytes

                                packet.displayDate = date.ToString("dd-MM-yyyy");
                                packet.displayTime = date.ToString("HH:mm:ss:fff");
                                
                                packet.displayData = String.Join(" ", stringBytes);

                                
                                byte[] byteArray = new byte[stringBytes.Length];

                                for (int i = 0; i < stringBytes.Length; i++)
                                {
                                    byteArray[i] = Convert.ToByte(stringBytes[i], 16);
                                }

                                string epm = sr.ReadLine();

                                packet.loadDataAndEndMarker(byteArray, epm);

                                packet.displayProtocolId = packet.protocolId.ToString();
                                packet.displayPathAddress = String.Join(String.Empty, Array.ConvertAll(packet.pathAddress.ToArray(), new Converter<byte, string> (x => x.ToString("X2"))));
                                packet.displayLogicalAddress = packet.logicalAddress.ToString();

                                file.addPacket(packet);

                                sr.ReadLine();
                                break;
                            case "E":
                                //Console.WriteLine("Error (E) At: " + date.ToString("dd-MM-yyyy HH:mm:ss:fff"));
                                string rawError = sr.ReadLine();

                                // FIX: what if the error is first or second in the packet?
                                Packet secondLastPacket = file.packets[file.packets.Count - 2];
                                Packet lastPacket = file.packets.Last();

                                Packet.Error error = new Packet.Error(rawError, date);
                                if (lastPacket.errorPacket == null)
                                {
                                    lastPacket.errorPacket = error;

                                    if (error.errorType == Packet.ErrorType.ERROR_PARITY)
                                    {
                                        // overrule on parity errors
                                        lastPacket.setError(Packet.ErrorType.ERROR_PARITY);
                                    }
                                    else
                                    {
                                        Tuple<Packet, Packet> last2Packets = new Tuple<Packet, Packet>(secondLastPacket, lastPacket);
                                        lastPacket.setError(ErrorChecker.determineError(last2Packets));
                                    }
                                }

                                // XXX: setter?

                                file.incrementErrCounts(lastPacket.error);

                                sr.ReadLine();
                                break;
                            default:
                                //Console.WriteLine('\n' + "File end date: " + date.ToString("dd-MM-yyyy HH:mm:ss:fff"));
                                sr.ReadLine();
                                break;
                        }
                    }

                }

            }
            catch (FileNotFoundException E)
            {
                // FIX: tell the user
                Console.WriteLine("File not found");
            }

            file.stats = new Stats(file);
            
            //Console.WriteLine("No of packets: " + file.stats.noOfPackets);
            //Console.WriteLine("No. of data chars: " + file.stats.noOfDataChars);
            //Console.WriteLine("Avg. Packet Rate: " + file.stats.avgPacketRate);
            //Console.WriteLine("Avg. Data Rate: " + file.stats.avgDataRate);

            return file;
        }

        public Packet lastPacket()
        {
            Packet packet = new IndustrialProject.Packet();

            return packet;
        }
    }
}
