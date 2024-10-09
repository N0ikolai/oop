using System;

public class CommantInv
{
    private List<InterfaceCommand> commands = new List<InterfaceCommand>();

    public void AddCommand(InterfaceCommand intefaceCommand)
    {
        commands.Add(intefaceCommand);
    }

    public void ExecuteCommand()
    {
        foreach (var command in commands)
        {
            command.Execute();
        }
}
