namespace Lab13_Command
{
    public class OnLightCommand : ICommand
    {
        private Light light;

        public OnLightCommand(Light light)
        {
            if (light == null)
            {
                throw new ArgumentNullException(nameof(light), "Свет не может быть равен null.");
            }   
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }
    }
}
