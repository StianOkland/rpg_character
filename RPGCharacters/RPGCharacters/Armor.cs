using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_character
{
    public class Armor : Item
    {
        public ArmorType ArmorType { get; set; }
        public Stats Attributes { get; set; }
    }
}
