using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs14_paskaita_Class
{
    public class FileWriterService
    {
        private readonly string _path = @"D:\GitHub\cs14_paskaita_Class\cs14_paskaita_Class\pseudoDB.txt";

        public void AppendText(string text)
        {
            using (StreamWriter sw = File.AppendText(_path))
            {
                sw.WriteLine(text);
            }
        }
        public void WriteAllText(string [] lines)
        {
            File.WriteAllLines(_path, lines);
            //File.WriteAllLines(_path, counter);
        }
        public List<string> GetAllLines()
        {
            var lines = File.ReadAllLines(_path);

            return lines.ToList();
        }
    }
}
