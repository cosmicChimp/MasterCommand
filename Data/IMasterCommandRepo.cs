namespace MasterCommand
{
    public interface IMasterCommandRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id)
    }
}