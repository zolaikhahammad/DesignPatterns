using DesignPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class Switcher
    {
        ////
        ///Invoker class
        ///
        public List<ICommand> commands;
        public Switcher()
        {
            commands = new List<ICommand>();
        }
        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }
        public void ExecuteCommand()
        {
            foreach(var item in commands)
            {
                item.Execute();
            }
                    
        }

    }
}
