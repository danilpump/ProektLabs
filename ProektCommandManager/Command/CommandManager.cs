using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektCommandManager
{
     class CommandManager
    {
        private CommandManager() { }

        private static CommandManager Instance;
        private bool flag = false;
        private List<ICommand> Commands = new List<ICommand>();

        public static CommandManager getInstance()
        {
            if (Instance == null)
                Instance = new CommandManager();
            return Instance;
        }

        public void RegisterCommand(ICommand command)
        {
            if (flag) return;
            else Commands.Add(command);
        }

        public void Undo()
        {
            if (Commands.Count != 1)
            {
                flag = true;
                Commands.Remove(Commands.Last());

                foreach (ICommand command in Commands)
                    command.Execute();
                flag = false;
            }
        }
    }
}
