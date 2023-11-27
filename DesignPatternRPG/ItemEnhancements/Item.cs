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
    }
}
