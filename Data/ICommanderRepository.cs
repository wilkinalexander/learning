using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepository
    {
         bool SaveChanges();
         IEnumerable<Command> GetAppCommands();
         Command GetCommandBy(int id); 
         void CreateCommand(Command command);
         void UpdateCommand(Command command);
    }
}