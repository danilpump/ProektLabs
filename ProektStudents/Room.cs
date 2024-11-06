using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektStudents
{
    internal class Room
    {
        private List<IListener> listeners = new List<IListener>();

        public void Enter(IListener listener) 
        {
            listeners.Add(listener);
        }

        public void Echo(string sound)
        {
            foreach (IListener listener in listeners)
                listener.Listen(sound);
        }
    }
}
