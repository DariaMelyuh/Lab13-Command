using Lab13_Command;
namespace Lab13_Command
{
    public class Remote
    {
        private Dictionary<int, ICommand> commands = new Dictionary<int, ICommand>();
        private List<ICommand> undoList = new List<ICommand>();

        public void Add(int number, ICommand remult, ICommand undo)
        {
            commands.Add(number, remult);
            undoList.Add(undo);
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
            if (undoList.Count > 0)
            {
                undoList[undoList.Count - 1].Execute();
                undoList.RemoveAt(undoList.Count - 1);
            }
            else
            {
                Console.WriteLine("Нет выполненных команд для отмены");
            }
        }
    }
}




