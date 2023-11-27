using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternRPG.CombatSystem;
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
        public IStrategy attackStrategy { get; protected set; }

        protected Character(string name, int health, int mana, int strength, int defense)
        {
            this.name = name;
            this.health = health;
            this.mana = mana;
            this.strength = strength;
            this.defense = defense;
            // Default to an aggresive strategy
            attackStrategy = new AggresiveStrategy();
        }

        public void SetStrategy(IStrategy strategy)
        {
            // Sets the character's strategy
            attackStrategy = strategy;
            Console.WriteLine("{0} has switched strategies: {1}!", name, strategy.GetType().Name);
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
        
        // Oh god, am I actually going to have to implement a combat system?
        public void Attack(Character target)
        {
            Console.WriteLine("{0} attacks {1}!", name, target.name);
        }

        // We could have the character move around the map
        // Maybe later
        public void Move(int deltax, int deltay)
        {
            Console.WriteLine("{0} moves {1} spaces to the right and {2} spaces down!", name, deltax, deltay);
        }
    }
}
