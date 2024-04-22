using RemoteController.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteController.Commands
{
    public class StereoOffCommand : ICommand
    {
        private readonly Stereo stereo;
        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.Off();
        }

        public void Undo()
        {
            stereo.On();
        }
        public override string ToString()
        {
            return $"Stereo Off ({stereo})";
        }
    }
}
