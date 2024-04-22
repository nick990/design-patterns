using RemoteController.Receivers;

namespace RemoteController.Commands
{
    public class LightOnCommand : ICommand
    {
        private readonly Light light;
        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.On();
        }

        public void Undo()
        {
            light.Off();
        }
        override public string ToString()
        {
            return $"Light On ({light})";
        }
    }
}
