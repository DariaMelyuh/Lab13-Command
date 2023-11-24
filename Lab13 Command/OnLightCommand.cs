namespace Lab13_Command
{
    public class OnLightCommand : ICommand
    {
        private Light light;

        public OnLightCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }

    }
}
