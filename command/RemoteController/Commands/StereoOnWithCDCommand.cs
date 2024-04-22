using RemoteController.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteController.Commands
{
    public class StereoOnWithCDCommand : ICommand
    {
        private readonly Stereo stereo;
        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.On();
            stereo.SetCD();
            stereo.SetVolume(11);
        }

        public void Undo()
        {
            stereo.Off();
        }

        public override string ToString()
        {
            return $"Stereo On with CD ({stereo})";
        }
    }
}
