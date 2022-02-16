using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_character
{
    public class Ranger : Role
    {
        /// <summary>
        /// Create a Ranger with base stats.
        /// </summary>
        public Ranger()
        {
            CharacterType = RoleType.RANGER;
            validWeapons = new WeaponType[] { WeaponType.BOWS };
            validArmors = new ArmorType[] { ArmorType.LEATHER, ArmorType.MAIL };
            BasePrimaryStats = new Stats() { Strength = 1, Dexterity = 7, Intelligence = 1 };
            LevelupStats = new Stats() { Strength = 1, Dexterity = 5, Intelligence = 1 };
            TotalStats = BasePrimaryStats;
            Damage = DPS * (1 + (TotalStats.Dexterity / 100));
        }

        /// <summary>
        /// Level up the character. Stats and Damage is modifyed.
        /// </summary>
        public void levelUp()
        {
            Level += 1;
            TotalStats = new Stats
            {
                Strength = TotalStats.Strength + LevelupStats.Strength,
                Dexterity = TotalStats.Dexterity + LevelupStats.Dexterity,
                Intelligence = TotalStats.Intelligence + LevelupStats.Intelligence
            };
            Damage = DPS * (1 + (TotalStats.Dexterity / 100));

        }

        /// <summary>
        /// Update damage when adding a weapon to the character.
        /// </summary>
        /// <param name="dps"></param>
        public override void updateDamage(double dps)
        {
            Damage = dps * (1 + (TotalStats.Dexterity / 100));
        }


        /// <summary>
        /// Update primary stats when adding armor to character.
        /// </summary>
        /// <param name="itemStat"></param>
        public override void updateStats(Stats itemStat)
        {
            TotalStats = new Stats
            {
                Strength = TotalStats.Dexterity + itemStat.Dexterity
            };
            Damage = DPS * (1 + (TotalStats.Dexterity / 100));

        }
    }
}
