using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRPG.QuestNotifications
{
    internal interface Observer
    {
        void Update(Subject subject);
    }
}
