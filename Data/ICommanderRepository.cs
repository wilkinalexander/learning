using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepository
    {
         bool SaveChanges();
         IEnumerable<Command> GetAllCommands();
         Command GetCommandBy(int id); 
         void CreateCommand(Command command);
         void UpdateCommand(Command command);
         void DeleteCommand(Command command);

    }
}