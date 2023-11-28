namespace Lab13_Command
{
    public class OnConditionerCommand : ICommand
    {
        private Conditioner conditioner;

        public OnConditionerCommand(Conditioner conditioner)
        {
            if (conditioner == null)
            {
                throw new ArgumentNullException(nameof(conditioner), "Кондиционер не может быть равен null.");
            }

            this.conditioner = conditioner;
        }

        public void Execute()
        {
            conditioner.On();
        }
    }
}
