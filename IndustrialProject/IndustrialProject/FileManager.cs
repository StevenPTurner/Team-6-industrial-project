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
        public string loadFile() //Note: Set as string temporarily until File class is built.
        {

            Console.WriteLine("This happened");
            
            List<string> packets = new List<String>();
            string errorFound = null;
            ErrorChecker ec = new ErrorChecker();
            DateTime date = new DateTime();
            int port;

            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\Connor\Desktop\team_project_example_files\test1_link1.REC"))
                {

                    date = Convert.ToDateTime(sr.ReadLine());
                    //Add date (file start date)

                    port = Convert.ToInt32(sr.ReadLine());
                    //Add port to file


                    while (sr.Peek() >= 0)
                    {

                        //   date = Convert.ToDateTime(sr.ReadLine());
                        Console.WriteLine("Was trying to convert...." + sr.ReadLine());
                        //Add date (Packet date)

                        string temp = sr.ReadLine();
                  
                        switch(temp)
                        {
                            case "P":
                                //sr.ReadLine() --- Add packet
                                string[] stringBytes = sr.ReadLine().Split(' ');
                                List<byte> byteList = new List<byte>();

                                for (int i = 0; i < stringBytes.Length; i++)
                                {
                                    byteList.Add(Convert.ToByte(stringBytes[i], 16));
                                }

                                byte[] byteArray = byteList.ToArray();

                                temp = sr.ReadLine();

                                switch (temp) //Do this inside ErrorChecker?
                                {
                                    case "None":
                                        //Add 'None' error
                                        Console.WriteLine("None was found");
                                        break;
                                    case "EEP":
                                        //Add 'EEP' error
                                        Console.WriteLine("EEP was found");
                                        break;
                                    default:
                                        break;
                                }
                                //sr.ReadLine(); //Skip blank line
                                sr.ReadLine(); //Skips empty line
                                break;
                            case "E":
                                sr.ReadLine(); // Will show us whether disconnect or parity error
                                sr.ReadLine(); //Skips empty line
                                date = Convert.ToDateTime(sr.ReadLine());
                                //date.AddMilliseconds();
                                Console.WriteLine("E was found");
                                Console.WriteLine("End of file: " + date + "." + date.Millisecond);
                                
                                //Add error.
                                break;
                            default:
                                break;
                        }

                       

                    }

                    // sr.ReadLine();
                    // date = Convert.ToDateTime(sr.ReadLine());
                    // Console.WriteLine("End of file..." + date);
                    //End date of file.
                   // Console.WriteLine(sr.ReadLine());

                while(sr.ReadLine() != null)
                    {
                        Console.WriteLine("Line here");
                    }
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

            return null;
        }
    }
}
