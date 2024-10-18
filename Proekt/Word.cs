using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt
{
    class Word : IPrintable
    {
        private string word;
        public Word(string _word) 
        {
            word = _word;
        }

        public void Print(IPrinter printer)
        {
            printer.print(word);
        }
    }
}
