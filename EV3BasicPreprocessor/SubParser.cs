using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV3BasicPreprocessor
{
    class SubParser
    {
        string path;
        string name;
        string extension;
        List<string> subNameMain;

        public SubParser(string filePath, string fileName, string fileExtension)
        {
            path = filePath;
            extension = fileExtension;
            name = fileName.Replace(extension, "");
        }

        public Dictionary<string, List<string>> Parse(Dictionary<string, List<string>> files)
        {
            Dictionary<string, List<string>> tmpFiles = new Dictionary<string, List<string>>();

            foreach (var words in files.Values)
            {
                foreach (var word in words)
                {
                    GetString(word);
                }
            }

            return tmpFiles;
        }

        private string[] GetString(string str)
        {
            string[] words = new string[] { };

            string tmpStr = str.Trim();

            int ind1 = tmpStr.IndexOf('(');
            int ind2 = tmpStr.LastIndexOf(')');
            int ind3 = tmpStr.IndexOf('.');
            int ind4 = tmpStr.IndexOf('\'');
            int ind5 = tmpStr.IndexOf('"');
            int ind6 = tmpStr.LastIndexOf('"');

            if (ind1 > -1 && ind2 > -1 && ind4 == -1 && (ind3 == -1 || (ind3 > ind1 && ind3 < ind2)) && (ind5 == -1 || (ind5 > ind1 && ind5 < ind2)) && (ind6 == -1 || (ind6 > ind1 && ind6 < ind2)))
            {
                Console.WriteLine(str);
            }

            return words;
        }
    }
}
