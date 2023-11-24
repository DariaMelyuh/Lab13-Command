namespace Lab13_Command
{
    public class OffLightCommand : ICommand
    {
        private Light light;

        public OffLightCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }

    }
}
