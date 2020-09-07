using System;
using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data
{
    public class SqlCommanderRespository:ICommanderRepository
    {
        private readonly CommanderContext context;

        public SqlCommanderRespository(CommanderContext context)
        {
            this.context = context;
        }
        public  IEnumerable<Command> GetAppCommands()
        {
            return context.Commands;
        }

        public Command GetCommandBy(int id)
        {
            return context.Commands.FirstOrDefault(c => c.Id == id);
        }

        public void CreateCommand(Command command)
        {
            if (command==null)
            {
                throw new ArgumentNullException(nameof(command));
            }
            context.Add(command);
           
           
        }

       public bool SaveChanges()
        {
            return (context.SaveChanges()>=0);
        }

        public void UpdateCommand(Command command)
        {
            var result =  (command!=null)?context.Update(command):throw new ArgumentNullException(nameof(command));
        }
        
    }
}