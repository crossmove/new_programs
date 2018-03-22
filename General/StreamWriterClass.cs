using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class StreamWriterClass
    {
        static void Method(string[] args)
        {
            // Get the directories currently on the C drive.
            DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();

            // Write each directory name to a file.
            using (StreamWriter sw = new StreamWriter(@"C:\CDriveDirs.txt"))
            {
                foreach (DirectoryInfo dir in cDirs)
                {
                    sw.WriteLine(dir.Name);

                }
            }

            // Read and show each line from the file. 
            string line = "";
            using (StreamReader sr = new StreamReader(@"C:\CDriveDirs.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

    }
}
