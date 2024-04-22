using RemoteController.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteController
{
    public class RemoteControl
    {
        private readonly ICommand[] onCommands;
        private readonly ICommand[] offCommands;
        private ICommand undoCommand;
        private const int SLOTS_NUMBER = 7;

        public RemoteControl()
        {
            ICommand noCommand = new NoCommand();
            onCommands = Enumerable.Repeat<ICommand>(noCommand, SLOTS_NUMBER).ToArray();
            offCommands = Enumerable.Repeat<ICommand>(noCommand, SLOTS_NUMBER).ToArray();
            undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n------ Remote Control ------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuilder.Append($"[slot {i}] {onCommands[i]}    {offCommands[i]}\n");
            }
            stringBuilder.Append($"[undo] {undoCommand}\n");
            return stringBuilder.ToString();
        }   
    }
}
