using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektCommandManager
{
    abstract class ACommand : ICommand
    {
        public virtual void Execute()
        {
            CommandManager.getInstance().RegisterCommand(this);
            doOperation();
        }
        public abstract void doOperation();
    }
}
