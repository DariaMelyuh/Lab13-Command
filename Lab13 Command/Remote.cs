using Lab13_Command;

public class Remote
{
    private Dictionary<int, ICommand> commands = new Dictionary<int, ICommand>();
    private List<ICommand> executed = new List<ICommand>();
    private List<ICommand> undone = new List<ICommand>();

    public void Add(int number, ICommand execute, ICommand undo)
    {
        var multiCommand = new MultiCommand(new List<ICommand> { execute, undo });
        commands.Add(number, multiCommand);
    }

    public void Execute(int number)
    {
        if (commands.ContainsKey(number))
        {
            ICommand command = commands[number];
            command.Execute();
            executed.Add(command);
        }
        else
        {
            Console.WriteLine("Кнопка не найдена");
        }
    }

    public void Undo()
    {
        if (executed.Count > 0)
        {
            ICommand lastCommand = executed[executed.Count - 1];
            undone.Add(lastCommand);
            executed.RemoveAt(executed.Count - 1);
        }
        else
        {
            Console.WriteLine("Нет выполненных команд для отмены");
        }
    }
}




