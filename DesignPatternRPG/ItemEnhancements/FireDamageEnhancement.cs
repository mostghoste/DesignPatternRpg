using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRPG.ItemEnhancements
{
    internal class FireDamageEnhancement : ItemDecorator
    {
        public FireDamageEnhancement(Item item) : base(item, "Flaming " + item.name)
        {
        }

        public override void Use()
        {
            // The decorator class can call the base class's methods
            base.Use();
            // The decorator class can also add additional functionality
            Console.WriteLine("It burns your enemy!", this.ToString());
        }

        public override int GetDamage()
        {
            // The decorator class can call the base class's methods
            return base.GetDamage() + 5;
        }
    }
}
