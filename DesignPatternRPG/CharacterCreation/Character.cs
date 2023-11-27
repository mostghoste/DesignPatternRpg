using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternRPG.QuestNotifications;

namespace DesignPatternRPG.CharacterCreation
{
    internal abstract class Character : Observer
    {
        public string name { get; protected set; }
        public int health { get; protected set; }
        public int mana { get; protected set; }
        public int strength { get; protected set; }
        public int defense { get; protected set; }

        protected Character(string name, int health, int mana, int strength, int defense)
        {
            this.name = name;
            this.health = health;
            this.mana = mana;
            this.strength = strength;
            this.defense = defense;
        }

        public override string ToString()
        {
            // Nicely formats all of the character's stats
            return string.Format("Name: {0}\nHealth: {1}\nMana: {2}\nStrength: {3}\nDefense: {4}", name, health, mana, strength, defense);
        }

        public void Update(Subject subject)
        {
            // If the subject is a quest, then the character will be notified of the quest's completion
            if (subject is Quest)
            {
                string questName = ((Quest)subject).questName;
                Console.WriteLine("{0} has completed a quest: {1}!", name, questName);
            }
        }
    }
}
