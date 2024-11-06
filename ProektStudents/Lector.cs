using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektStudents
{
    internal class Lector : IListener
    {
        public void Listen(string sound)
        {            
        }

        public void Say(Room r, string sound) 
        {
            r.Echo(sound);
        }
    }
}
