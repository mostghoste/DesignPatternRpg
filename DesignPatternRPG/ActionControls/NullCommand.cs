using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRPG.ActionControls
{
    internal class NullCommand : ICommand
    {
        public void Execute()
        {
            // Do nothing
        }
    }
}
