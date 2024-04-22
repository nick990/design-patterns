using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteController.Commands
{
    public class MacroCommand : ICommand
    {
        IEnumerable<ICommand> commands;
        public MacroCommand(IEnumerable<ICommand> commands)
        {
            this.commands = commands;
        }
        public void Execute()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in commands.Reverse())
            {
                command.Undo();
            }
        }

        override public string ToString()
        {
            var str = "Macro Command: [";
            foreach (var command in commands)
            {
                str += command.ToString() + ", ";
            }
            str += "]";
            return str;
        }
    }
}
