namespace Lab13_Command
{
    public class OffLightCommand : ICommand
    {
        private Light light;

        public OffLightCommand(Light light)
        {
            if (light == null)
            {
                throw new ArgumentNullException(nameof(light), "Свет не может быть равен null.");
            }

            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }
    }
}
