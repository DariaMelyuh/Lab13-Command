namespace Lab13_Command
{
    public class MultiCommand : ICommand
    {
        private readonly List<ICommand> commandList = new List<ICommand>();

        public MultiCommand(List<ICommand> commands)
        {
            commandList.AddRange(commands);
        }

        public void Execute()
        {
            foreach (ICommand command in commandList)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (ICommand command in commandList)
            {
                Console.WriteLine("Отмена последнего действия... ");
                command.Execute();
            }
        }
    }
}
