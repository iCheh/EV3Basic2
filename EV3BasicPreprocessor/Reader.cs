using System;
using System.IO;

namespace EV3BasicPreprocessor
{
    class Reader
    {
        private string[] text;

        public Reader()
        {
        }

        public string[] ReadFile(string path, string name)
        {
            if (!File.Exists(path + name))
            {
                Console.WriteLine("file " + path + name + " not found");
                return text = new string[] { };
            }
            return text = File.ReadAllLines(path + name);
        }
    }
}
