using Lab13_Command;
public class Program
{
    static void Main()
    {
        Light light = new Light();
        Conditioner conditioner = new Conditioner();

        Remote remote = new Remote();

        // Добавляем команды включения света и кондиционера
        remote.Add(0, new OnLightCommand(light), new OffLightCommand(light));
        remote.Add(1, new OnConditionerCommand(conditioner), new OffConditionerCommand(conditioner));

        // Выполняем команды
        remote.Execute(0); // Включить свет
        Console.WriteLine();

        remote.Execute(1); // Включить кондиционер
        Console.WriteLine();

        // Отменяем последнюю выполненную команду
        remote.Undo();
        Console.WriteLine();

        Console.ReadLine();
    }
}
