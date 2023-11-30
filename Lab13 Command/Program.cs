using Lab13_Command;
using System;
class Program
{
    static void Main()
    {
        Remote remote = new Remote();
        Conditioner conditioner = new Conditioner();
        Light light = new Light();
       
        remote.Add(0, new OnConditionerCommand(conditioner), new OffConditionerCommand(conditioner));
        remote.Execute(0);
        Console.WriteLine();

        Console.WriteLine("Отмена последнего действия... ");
        remote.Undo();
        Console.WriteLine();
        
        MultiCommand multiCommandOn = new MultiCommand(new List<ICommand> { new OnLightCommand(light), new OnConditionerCommand(conditioner) });
        MultiCommand multiCommandOff = new MultiCommand(new List<ICommand> { new OffConditionerCommand(conditioner), new OffLightCommand(light) });
       
        remote.Add(1, multiCommandOn, multiCommandOff);
        remote.Execute(1);
        Console.WriteLine();

        Console.WriteLine("Отмена действий... ");
        remote.Undo();
        Console.ReadLine();
    }
}
