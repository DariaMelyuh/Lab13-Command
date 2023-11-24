namespace Lab13_Command
{
    class MultiCommand : ICommand
    {
        private List<ICommand> commandList = new List<ICommand>();

        public MultiCommand(List<ICommand> commands)
        {
            foreach (var command in commands)
            {
                commandList.Add(command);
            }
        }

        public void Execute()
        {
            foreach (var command in commandList)
            {
                command.Execute();
            }
        }
    }
}
