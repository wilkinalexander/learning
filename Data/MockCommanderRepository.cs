using System;
using System.Collections.Generic;
using Commander.Data;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepository : ICommanderRepository
    {
        public IEnumerable<Command> GetAppCommands()
        {
           return new List<Command>
           {
               new Command{Id=1, HowTo="Boid an egg", Line="Boil water", Platform= "Katalle & Pan"},
               new Command{Id=2, HowTo="Cut bread", Line="Get a knife", Platform= "Knife & chopping board"},
               new Command{Id=3, HowTo="Make a cup of tea", Line="Place teabag in cup", Platform= "Katalle & Pan"}
           };
        }

        public Command GetCommandBy(int id)
        {
            return new Command{Id=1, HowTo="Boid an egg", Line="Boil water", Platform= "Katalle & Pan"};
        }

        public void UpdateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        void ICommanderRepository.CreateCommand(Command command)
        {
            throw new NotImplementedException();
        }

        bool ICommanderRepository.SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}