namespace Lab13_Command
{
    public class OffConditionerCommand : ICommand
    {
        private Conditioner conditioner;

        public OffConditionerCommand(Conditioner conditioner)
        {
            if (conditioner == null)
            {
                throw new ArgumentNullException(nameof(conditioner), "Кондиционер не может быть равен null.");
            }

            this.conditioner = conditioner;
        }

        public void Execute()
        {
            conditioner.Off();
        }

    }
}
