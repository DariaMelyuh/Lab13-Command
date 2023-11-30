namespace Lab13_Command
{
    public class OffConditionerCommand : ICommand
    {
        private Conditioner _conditioner;

        public OffConditionerCommand(Conditioner conditioner)
        {
            if (conditioner == null)
            {
                throw new ArgumentNullException(nameof(conditioner), "Кондиционер не может быть равен null.");
            }

            this._conditioner = conditioner;
        }

        public void Execute()
        {
            _conditioner.Off();
        }
    }
}
