using Lab13_Command;
namespace Lab13_Command
{
    public class Remote
    {
        private Dictionary<int, ICommand> commands = new Dictionary<int, ICommand>();
        private Stack<Action> undoAction = new Stack<Action>();

        public void Add(int number, ICommand remult, Action undo)
        {
            commands.Add(number, remult);
            undoAction.Push(undo);
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
                Console.WriteLine("Кнопка не найдена");
            }
        }

        public void Undo()
        {
            if (undoAction.Count > 0)
            {
                Action lastUndo = undoAction.Pop();
                lastUndo();
            }
            else
            {
                Console.WriteLine("Нет выполненных команд для отмены");
            }
        }
    }
}




