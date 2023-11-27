using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRPG.ItemEnhancements
{
    internal class Sword : Item
    {
        public Sword() : base("Sword")
        {
        }

        public override void Use()
        {
            Console.WriteLine(string.Format("You swing the {0}!", this.ToString()));
        }

        public override int GetDamage()
        {
            return 10;
        }
    }
}
