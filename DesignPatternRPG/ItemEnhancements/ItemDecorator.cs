using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRPG.ItemEnhancements
{
    // When using the decorator pattern, the decorator class must inherit from the base class
    internal abstract class ItemDecorator : Item
    {
        // The decorator class has an instance of the base class
        protected Item item;

        // The decorator class must have a constructor that takes in an instance of the base class
        protected ItemDecorator(Item item, string name) : base(name)
        {
            this.item = item;
        }
    }
}
