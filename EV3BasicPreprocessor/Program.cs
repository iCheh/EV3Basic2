using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EV3BasicPreprocessor
{
    class Program
    {
        static void Main(string[] args)
        {
            Preprocessor preprocessor = new Preprocessor();
            
            var text = preprocessor.Start(args);
            //preprocessor.WriteToConsole(text);
            var stream = new MemoryStream();
            preprocessor.WriteToStream(text, stream);
            stream.Position = 0;
            var reader = new StreamReader(stream);

            Console.WriteLine("OK");
            Console.WriteLine(stream.Length.ToString());
            Console.WriteLine("=====");

            while (!reader.EndOfStream)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }
}
