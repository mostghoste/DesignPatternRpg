using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRPG.ActionControls
{
    internal class CommandInvoker
    {
        private ICommand command;

        public CommandInvoker()
        {
            command = new NullCommand();
        }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
