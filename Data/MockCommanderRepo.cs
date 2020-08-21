using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="How To", Line="Line", Platform="Platform"},
                new Command{Id=1, HowTo="How To two", Line="Line two", Platform="Platform three"},
                new Command{Id=2, HowTo="How To three", Line="Line three", Platform="Platform three"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="How To", Line="Line", Platform="Platform"};
        }
    }
}