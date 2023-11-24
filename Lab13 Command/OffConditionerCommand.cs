namespace Lab13_Command
{
    public class OffConditionerCommand : ICommand
    {
        private Conditioner conditioner;

        public OffConditionerCommand(Conditioner conditioner)
        {
            this.conditioner = conditioner;
        }

        public void Execute()
        {
            conditioner.Off();
        }

    }
}
