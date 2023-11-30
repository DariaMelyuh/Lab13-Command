using Lab13_Command;
namespace Lab13_Command
{
    public class Remote
    {
        private Dictionary<int, ICommand> commands = new Dictionary<int, ICommand>();
        private Stack<ICommand> undoStack = new Stack<ICommand>();

        public void Add(int number, ICommand remult, ICommand undo)
        {
            commands.Add(number, remult);
            undoStack.Push(undo);
        }

        public void Execute(int number)
        {
            if (commands.ContainsKey(number))
            {
                ICommand remult = commands[number];
                remult.Execute();
            }
            else
            {
                throw new ArgumentException("Кнопка не найдена", nameof(number));
            }
        }

        public void Undo()
        {
            if (undoStack.Count > 0)
            {
                
                ICommand command = undoStack.Pop();
                command.Execute();
            }
            else
            {
                Console.WriteLine("Нет выполненных команд для отмены");
            }
        }
    }
}




