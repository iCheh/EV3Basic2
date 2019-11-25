using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV3BasicPreprocessor
{
    class Errore
    {
        public Errore ()
        {
        }

        // Здесь будем проверять синтаксические ошибки файлов включений
        public bool FindErrore (Dictionary<string, string[]> text, string extension)
        {
            bool err = false;

            return err;
        }

        // Здесь будем проверять синтаксические ошибки основной программы
        public bool FindErrore(List<string> text, string name, string extension)
        {
            bool err = false;

            return err;
        }
    }
}
