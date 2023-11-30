namespace Lab13_Command
{
    public class MultiCommand : ICommand
    {
        private readonly List<ICommand> _commandList = new List<ICommand>();

        public MultiCommand( List<ICommand> command)
        {
           _commandList.AddRange(command);
        }

        public void Execute()
        {
            foreach (ICommand command in _commandList)
            {
                command.Execute();
            }
            
        }
    }
}
