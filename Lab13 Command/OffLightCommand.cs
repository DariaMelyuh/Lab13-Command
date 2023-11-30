namespace Lab13_Command
{
    public class OffLightCommand : ICommand
    {
        private Light _light;

        public OffLightCommand(Light light)
        {
            if (light == null)
            {
                throw new ArgumentNullException(nameof(light), "Свет не может быть равен null.");
            }

            this._light = light;
        }

        public void Execute()
        {
            _light.Off();
        }
    }
}
