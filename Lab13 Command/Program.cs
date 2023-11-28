using Lab13_Command;
using System;
class Program
{
    static void Main()
    {
        var remote = new Remote();
        var conditioner = new Conditioner();

        Console.WriteLine("Команды: ");
        remote.Add(1, new OnConditionerCommand(conditioner), conditioner.Off);
        remote.Add(2, new OffConditionerCommand(conditioner), conditioner.On);

        remote.Execute(1); 
        remote.Execute(2); 
        Console.WriteLine();

        Console.WriteLine("Отмена последнего действия... ");
        remote.Undo();
        Console.WriteLine();

        Console.WriteLine("Отмена последнего действия... ");
        remote.Undo();
        Console.WriteLine();

        Console.WriteLine("Отмена последнего действия... ");
        remote.Undo();
        Console.ReadLine();
    }
}