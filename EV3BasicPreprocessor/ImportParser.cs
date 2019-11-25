using System;
using System.Collections.Generic;
using System.Windows;

namespace EV3BasicPreprocessor
{
    class ImportParser
    {
        Dictionary<string, List<string>> listFiles;
        List<string> imports;
        Dictionary<string, string[]> importFiles;
        List<string> main;
        string path;
        string name;
        string extension;
        Errore errore;

        public ImportParser(string filePath, string fileName, string fileExtension)
        {
            listFiles = new Dictionary<string,List<string>>();
            importFiles = new Dictionary<string, string[]>();
            imports = new List<string>();
            main = new List<string>();
            path = filePath;
            extension = fileExtension;
            errore = new Errore();
            name = fileName.Replace(extension, "");
        }
        public Dictionary<string, List<string>> Parse(string[] text)
        {

            ParseImport(text);

            bool errMain = errore.FindErrore(main, name, extension);
            bool errImports = errore.FindErrore(importFiles, extension);
            if (errMain || errImports)
            {
                return listFiles;
            }

            if (main.Count > 0)
            {
                var list = new List<string>();
                foreach (var s in main)
                {
                    string tmpStr;
                    tmpStr = s.Trim();

                    if (tmpStr != "")
                    {
                        if (!Import(tmpStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)))
                        { 
                            list.Add(s);
                        }
                    }
                    else if (list.Count > 0)
                    {
                        list.Add(s);
                    }
                }
                listFiles.Add(name, list);
            }
            if (importFiles.Count > 0)
            {
                for (int a = 0; a < importFiles.Count; a++)
                {
                    var list = new List<string>();
                    list.Add("");
                    var words = importFiles[imports[a]];

                    foreach (var s in words)
                    {
                        string tmpStr;
                        tmpStr = s.Trim();

                        if (tmpStr != "")
                        {
                            if (!Import(tmpStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)))
                            {
                                list.Add(s);
                            }
                        }
                        else if (list.Count > 0)
                        {
                            list.Add(s);
                        }
                        
                    }
                    
                    listFiles.Add(imports[a], list);
                }
            }
            return listFiles;
        }

        private bool Import (string[] words)
        {
            if (words[0] == "#import")
            {
                if (words.Length != 2)
                {
                    Console.WriteLine("Incorrect #import definition");
                    return false;
                }
                return true;
            }
            return false;
        }

        private void ParseImport(string[] text)
        {
            string tmpStr;

            if (main.Count == 0)
            {
                foreach (var s in text)
                {
                    main.Add(s);
                }
            }

            for (int i = 0; i < text.Length; i++)
            {
                tmpStr = text[i];
                // Удалим начальные и конечные пробелы
                tmpStr = tmpStr.Trim();

                if (tmpStr.Length > 1 && tmpStr != "")
                {
                    if (tmpStr[0] == '#')
                    {
                        string[] words = tmpStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (Import(words) && words[1].Replace("\"", "") != name && !importFiles.ContainsKey(words[1]))
                        {
                            string[] newFile = new Reader().ReadFile(path, words[1].Replace("\"", "") + extension);
                            //if (!importFiles.ContainsKey(words[1]))
                            //{
                                importFiles.Add(words[1], newFile);
                                imports.Add(words[1]);
                            //}
                            ParseImport(newFile);
                        }
                    }
                }
            }
        }
    }
}
