using System.Collections.Generic;
using System.IO;

namespace EV3BasicPreprocessor
{
    class Writer
    {
        public void WriteFile(string path, string name, List<string> text, string suf)
        {
            string tmpName = "out_";
            int index = name.IndexOf('.');
            for (int i = 0; i < index; i++)
            {
                tmpName += name[i];
            }
            tmpName += suf;
            File.WriteAllLines(path + tmpName, text);
        }
    }
}
