using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command> {
                new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "kattle and pan" },
                new Command { Id = 1, HowTo = "Cut a bread", Line = "get a knife", Platform = "knife & chopping board" },
                new Command { Id = 2, HowTo = "make cup of tea", Line = "Place tea bag in cup", Platform = "kattle and cup" }
            };
            return commands;
        }

        public Command GetCommandById(int Id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "kattle and pan" };
        }
    }
}