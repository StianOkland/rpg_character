using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_character
{
    public class Worrier : Role
    {
        /// <summary>
        /// Create a Worrier with base stats.
        /// </summary>
        public Worrier()
        {
            CharacterType = RoleType.WORRIER;
            validWeapons = new WeaponType[] { WeaponType.AXE, WeaponType.HAMMERS, WeaponType.SWORDS };
            validArmors = new ArmorType[] { ArmorType.MAIL, ArmorType.PLATE };
            BasePrimaryStats = new Stats() { Strength = 5, Dexterity = 2, Intelligence = 1 };
            LevelupStats = new Stats() { Strength = 3, Dexterity = 2, Intelligence = 1 };
            TotalStats = BasePrimaryStats;
            Damage = DPS * (1 + (5 / 100));
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
            Damage = DPS * (1 + (TotalStats.Strength / 100));

        }

        /// <summary>
        /// Update damage when adding a weapon to the character.
        /// </summary>
        /// <param name="dps"></param>
        public override void updateDamage(double dps)
        {
            Damage = dps * (1 + (TotalStats.Strength / 100));
        }


        /// <summary>
        /// Update primary stats when adding armor to character.
        /// </summary>
        /// <param name="itemStat"></param>
        public override void updateStats(Stats itemStat)
        {
            TotalStats = new Stats
            {
                Strength = TotalStats.Strength + itemStat.Strength
            };

            Damage = DPS * (1 + (TotalStats.Strength / 100));

        }
    }
}
