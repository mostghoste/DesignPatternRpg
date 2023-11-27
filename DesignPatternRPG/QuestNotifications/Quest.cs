using DesignPatternRPG.QuestNotifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.Observer Pattern - Quest Notification System

//    Task: Implement the Observer pattern to create a quest notification system.
//    Elements to Include:
//        Quest subjects that players can subscribe to
//        Notification system to update players on quest changes (e.g., quest completion, updates)

namespace DesignPatternRPG.QuestNotifications
{
    internal class Quest : Subject
    {
        public string questName { get; private set;}
        public string questDescription { get; private set; }
        public bool questComplete { get; private set; }

        public Quest(string questName, string questDescription)
        {
            this.questName = questName;
            this.questDescription = questDescription;
            this.questComplete = false;
        }

        public void CompleteQuest()
        {
            this.questComplete = true;
            Notify();
        }

        public override string ToString()
        {
            return string.Format("Quest Name: {0}\nQuest Description: {1}\nQuest Complete: {2}", questName, questDescription, questComplete);
        }
    }
}
