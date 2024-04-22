using RemoteController.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteController.Commands
{
    public class LightOffCommand : ICommand
    {
        private readonly Light light;
        public LightOffCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.Off();
        }

        public void Undo()
        {
            light.On();
        }
        public override string ToString()
        {
            return $"Light Off ({light})";
        }
    }
}
