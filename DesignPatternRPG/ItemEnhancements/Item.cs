using DesignPatternRPG.ItemEnhancements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//6.Decorator Pattern - Item Enhancements

//    Task: Implement the Decorator pattern to add enhancements or abilities to items.
//    Elements to Include:
//        Base item class
//        Decorators for item enhancements (e.g., fire damage, increased durability)
namespace DesignPatternRPG.ItemEnhancements
{
    internal abstract class Item
    {
        public string name { get; protected set; }

        protected Item(string name)
        {
            this.name = name;
        }

        public abstract void Use();

        // While not every item will have damage, this method is used to demonstrate the Decorator pattern
        // In a real game, this method would be in a "Weapon" class that inherits from Item
        public abstract int GetDamage();

        public override string ToString()
        {
            return name;
        }
    }
}
