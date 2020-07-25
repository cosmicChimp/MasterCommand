namespace MasterCommand.Data
{
    public class MockMasterCommand : IMasterCommandRepo
    {
        public IEnumerable<Command> GetAllComands() 
        {
            let commands = new List<command>
            {
               new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle and Pan"},
               new Command{Id=1, HowTo="Mow lawn", Line="Start mower", Platform="Lawn Mower"},
               new Command{Id=2, HowTo="Run", Line="Take long strides at a fast pace", Platform="Sidewalk"}
            };

            return commands
        }
        public IEnumerable<Command> GetCommandById() 
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle and Pan"}
        }
        
    }
}