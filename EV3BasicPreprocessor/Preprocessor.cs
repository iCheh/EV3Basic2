using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV3BasicPreprocessor
{
    public class Preprocessor
    {
        string path;
        string name;
        string extension;
        Reader reader;
        ImportParser import;
        Writer writer;
        SubParser sub;

        public Preprocessor()
        {
            reader = new Reader();
            writer = new Writer();
        }

        public List<string> Start(string[] args)
        {
            path = GetPath(args[0]);
            name = GetName(args[0]);
            extension = GetExtension(args[0]);
            import = new ImportParser(path, name, extension);
            sub = new SubParser(path, name, extension);
            List<string> outFile = new List<string>();

            string[] text = reader.ReadFile(path, name);
            if (text.Length > 0)
            {
                Dictionary<string, List<string>> listFilesImport = import.Parse(text);
                Dictionary<string, List<string>> listFilesSubcall = sub.Parse(listFilesImport);

                if (listFilesImport.Count > 0)
                {
                    
                    foreach (var str in listFilesImport)
                    {
                        foreach (var s in str.Value)
                        {
                            outFile.Add(s);
                        }
                    }
                }
            }

            return outFile;
        }

        private string GetPath(string str)
        {
            string path = "";
            int index = str.LastIndexOf('\\');
            for (int i = 0; i <= index; i++)
            {
                path += str[i];
            }
            return path;
        }

        private string GetName(string str)
        {
            string name = "";
            int index = str.LastIndexOf('\\');
            for (int i = index + 1; i < str.Length; i++)
            {
                name += str[i];
            }
            return name;
        }
        private string GetExtension(string str)
        {
            string extension = "";
            int index = str.LastIndexOf('.');
            for (int i = index; i < str.Length; i++)
            {
                extension += str[i];
            }
            return extension;
        }

        public void WriteToFile(List<string> outFile)
        {
            writer.WriteFile(path, name, outFile, extension);
        }

        public void WriteToConsole(List<string> outFile)
        {
            foreach (var s in outFile)
            {
                Console.WriteLine(s);
            }
        }

        public void WriteToStream (List<string> outFile, Stream stream)
        {
            StreamWriter writer = new StreamWriter(stream);
            foreach (var s in outFile)
            {
                writer.WriteLine(s);
            }
            writer.Flush();
        }
    }
}
