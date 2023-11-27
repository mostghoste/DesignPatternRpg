using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRPG.ItemEnhancements
{
    // This is the hurtful enhancement. It multiplies the damage of the item by 2.
    // In a real game, it would probably inherit WeaponDecorator instead of ItemDecorator.
    internal class HurtfulEnhancement : ItemDecorator
    {
        public HurtfulEnhancement(Item item) : base(item, "Hurtful " + item.name)
        {
        }

        public override void Use()
        {
            // The decorator class can call the base class's methods
            base.Use();
            // The decorator class can also add additional functionality
            Console.WriteLine("The damage is multiplied by the hurtful enhancement!");
        }

        public override int GetDamage()
        {
            // The decorator class can call the base class's methods
            return base.GetDamage() * 2;
        }
    }
}
