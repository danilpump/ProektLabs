using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProektStudents
{
    internal class Student : IListener
    {
        public void Listen(string sound)
        {
            this.Write(sound);
        }

        protected void Write(string text) 
        {
            Console.WriteLine(text);
        }
    }
}
