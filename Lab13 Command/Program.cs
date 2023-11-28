using Lab13_Command;
using System;
class Program
{
    static void Main()
    {
        Remote remote = new Remote();
        Conditioner conditioner = new Conditioner();    
        remote.Add(0, new OnConditionerCommand(conditioner), new OffConditionerCommand(conditioner));
        remote.Execute(0);

        Console.WriteLine("Отмена последнего действия... ");
        remote.Undo();
        Console.WriteLine();
        
        Light light = new Light();
        MultiCommand multiCommand = new MultiCommand(new List<ICommand> {new OnLightCommand(light), new OffLightCommand(light)});
        multiCommand.Execute();
        
        Console.WriteLine();
        ((MultiCommand)multiCommand).Undo();
        Console.ReadLine();
    }
}