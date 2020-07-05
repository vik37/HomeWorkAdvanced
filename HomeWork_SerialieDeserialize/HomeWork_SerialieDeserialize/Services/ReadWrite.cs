using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_SerialieDeserialize.Services
{
    public class ReadWrite
    {
        public void WriteFile(string path, string data)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(data);
            }
            
        }
        
        public string ReadFile(string path)
        {
            string result = "";
            if (!File.Exists(path))
            {
                return "File doesn't exist";
            }

            using (StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadToEnd();
            }
           
            return result;
        }
       
    }
}
