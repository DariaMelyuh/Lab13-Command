namespace Lab13_Command
{
    public class OnConditionerCommand : ICommand
    {
        private Conditioner conditioner;

        public OnConditionerCommand(Conditioner conditioner)
        {
            this.conditioner = conditioner;
        }

        public void Execute()
        {
            conditioner.On();
        }

    }
}
