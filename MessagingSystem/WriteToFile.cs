using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace MessagingSystem
{
    public class WriteToFile
    {
        public void performWrite(ArrayList output)
        {
            //writting the messages to a file
            using (TextWriter writer = File.CreateText(@"H:\Software Engineering\Course Work\output.json"))
            {
                //looping though the array list to add all messages to a file
                foreach (string message in output)
                {
                    writer.WriteLine(message);
                }
            }
        }

        public void performSirWrite(ArrayList output)
        {
            //writting the messages to a file
            using (TextWriter writer = File.CreateText(@"H:\Software Engineering\Course Work\SIRoutput.json"))
            {
                //looping though the array list to add all messages to a file
                foreach (string message in output)
                {
                    writer.WriteLine(message);
                }
            }
        }
    }
}
