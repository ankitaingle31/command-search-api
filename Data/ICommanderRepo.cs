using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands(); // get all commands
        Command GetCommandById(int id); // get a specific command
        void CreateCommand(Command cmd); // create a new command
        void UpdateCommand(Command cmd); // update an existing command
        void DeleteCommand(Command cmd); // delete a command
    }
}
