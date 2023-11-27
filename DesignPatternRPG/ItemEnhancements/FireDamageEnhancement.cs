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
    }
}
