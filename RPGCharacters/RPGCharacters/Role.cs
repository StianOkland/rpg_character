using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_character
{
    public abstract class Role
    {
 
        public Role()
        {
            Name = "TestHero";
            Level = 1;
            DPS = 1;
            Inventory = new Dictionary<string, Item>();
            TotalStats = new Stats();
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public double Damage { get; set; }
        public double DPS { get; set; }
        public RoleType CharacterType { get; set; }

        public Stats TotalStats { get; set; }
        public Stats BasePrimaryStats { get; set; }
        public Stats LevelupStats { get; set; }


        public Dictionary<string, Item> Inventory { get; set; }
        public WeaponType[] validWeapons { get; set; }
        public ArmorType[] validArmors { get; set; }

        /// <summary>
        /// Abstract class each character must implement to update its damage when adding a weapon.
        /// </summary>
        /// <param name="damage"></param>
        public abstract void updateDamage(double damage);

        /// <summary>
        /// Abstract class each character must implement to update its stats when adding armor.
        /// </summary>
        /// <param name="stats"></param>
        public abstract void updateStats(Stats stats);

        /// <summary>
        /// Display character stats.
        /// </summary>
        /// <returns> StringBuilder-object with character stats. </returns>
        public StringBuilder CharacterStats()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name " + Name + "\n");
            sb.Append("Level " +Level + "\n");
            sb.Append("Strenth " + TotalStats.Strength + "\n");
            sb.Append("Dexterity " + TotalStats.Dexterity + "\n");
            sb.Append("Intelligence " + TotalStats.Intelligence + "\n");
            sb.Append("Damage " + Damage);

            return sb;
        }

        /// <summary>
        /// Add weapon to characters inventory.
        /// </summary>
        /// <param name="weapon"></param>
        /// <returns> Return string New weapon equipped! </returns>
        /// <exception cref="InvalidWeaponException"></exception>
        public string AddWeapon(Weapon weapon)
        {
 
            if(weapon.ItemLevel <= Level && validWeapons.Contains(weapon.WeaponType) == true)
            {
                Inventory.Add(weapon.ItemSlot.ToString(), weapon);
                DPS = (weapon.WeaponAttributes.Damage * weapon.WeaponAttributes.AttackSpeed);
                updateDamage(DPS);
                return "New weapon equipped!";
            }
            else
            {
                throw new InvalidWeaponException();
            }
            
        }

        /// <summary>
        /// Add armor to character inventory.
        /// </summary>
        /// <param name="armor"></param>
        /// <returns> Return string New armour equipped! </returns>
        /// <exception cref="InvalidArmorException"></exception>
        public string AddArmor(Armor armor)
        {

            if (armor.ItemLevel <= Level && validArmors.Contains(armor.ArmorType) == true)
            {
                Inventory.Add(armor.ItemSlot.ToString(), armor);
                updateStats(armor.Attributes);
                return "New armour equipped!";
            }
            else
            {
                throw new InvalidArmorException();

            }
        }

    }
}
