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
            
            List<string> packets = new List<String>();
            string errorFound = null;
            ErrorChecker ec = new ErrorChecker();
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\Connor\Desktop\team_project_example_files\test1_link1.REC"))
                {
                    while (sr.Peek() >= 0)
                    {
                        Console.WriteLine(sr.ReadLine());

                        if (sr.ReadLine().Equals("P"))
                        {
                            //sr.ReadLine() --- Add packet
                            string[] stringBytes = sr.ReadLine().Split(' ');
                            List<byte> byteList = new List<byte>();

                            for (int i = 0; i < stringBytes.Length; i++)
                            {
                                byteList.Add(Convert.ToByte(stringBytes[i], 16));
                            }

                            byte[] byteArray = byteList.ToArray();

                            if (sr.ReadLine().Equals("None"))
                            {

                            }

                            sr.ReadLine(); //Skip blank line
                        }

                        if (sr.ReadLine().Equals("E"))
                        {

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
