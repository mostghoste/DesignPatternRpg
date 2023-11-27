using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRPG.ItemEnhancements
{
    internal class Bow : Item
    {
        public Bow() : base("Bow")
        {
        }

        public override void Use()
        {
            Console.WriteLine(string.Format("You shoot with the {0}!", this.ToString()));
        }

        public override int GetDamage()
        {
            return 20;
        }
    }
}
