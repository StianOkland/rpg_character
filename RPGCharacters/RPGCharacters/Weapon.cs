using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_character
{
    public class WeaponAttributes
    {
        public double Damage { get; set; }
        public double AttackSpeed { get; set; }
    }

    public class Weapon: Item
    {
  
        public WeaponType WeaponType { get; set; }
        public WeaponAttributes WeaponAttributes { get; set; }

    }
}
