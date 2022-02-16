using rpg_character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RPGCharactersTests
{
    public class RPGItemTests
    {


        Weapon testAxeLevel2 = new Weapon()
        {
            ItemName = "Common axe",
            ItemLevel = 2,
            ItemSlot = ItemSlot.WEAPON,
            WeaponType = WeaponType.AXE,
            WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
        };

        Weapon testAxeLevel1 = new Weapon()
        {
            ItemName = "Common axe",
            ItemLevel = 1,
            ItemSlot = ItemSlot.WEAPON,
            WeaponType = WeaponType.AXE,
            WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
        };

        Weapon testBow = new Weapon()
        {
            ItemName = "Common bow",
            ItemLevel = 1,
            ItemSlot = ItemSlot.WEAPON,
            WeaponType = WeaponType.BOWS,
            WeaponAttributes = new WeaponAttributes() { Damage = 12, AttackSpeed = 0.8 }
        };

        Armor testPlateBodyLevel2 = new Armor()
        {
            ItemName = "Common plate body armor",
            ItemLevel = 2,
            ItemSlot = ItemSlot.BODY,
            ArmorType = ArmorType.PLATE,
            Attributes = new Stats() { Strength = 1 }
        };

        Armor testPlateBodyLevel1 = new Armor()
        {
            ItemName = "Common plate body armor",
            ItemLevel = 1,
            ItemSlot = ItemSlot.BODY,
            ArmorType = ArmorType.PLATE,
            Attributes = new Stats() { Strength = 1 }
        };

        Armor testClothHead = new Armor()
        {
            ItemName = "Common cloth head armor",
            ItemLevel = 1,
            ItemSlot = ItemSlot.HEAD,
            ArmorType = ArmorType.CLOTH,
            Attributes = new Stats() { Intelligence = 5 }
        };


        [Fact]
        public void Item_EquipAHighLevelWeapon_ExceptionShouldBeThrown()
        {
            //Arrange
            Worrier worrier = new Worrier();

            //Assert
            Assert.Throws<InvalidWeaponException>(() => worrier.AddWeapon(testAxeLevel2));
        }

        [Fact]
        public void Item_EquipAAHighLevelArmor_ExceptionShouldBeThrown()
        {
            //Arrange
            Worrier worrier = new Worrier();

            //Assert
            Assert.Throws<InvalidArmorException>(() => worrier.AddArmor(testPlateBodyLevel2));
        }

        [Fact]
        public void Item_EquipAWrongWeapon_ExceptionShouldBeThrown()
        {
            //Arrange
            Worrier worrier = new Worrier();

            //Assert
            Assert.Throws<InvalidWeaponException>(() => worrier.AddWeapon(testBow));
        }

        [Fact]
        public void Item_EquipAWrongArmor_ExceptionShouldBeThrown()
        {
            //Arrange
            Worrier worrier = new Worrier();

            //Assert
            Assert.Throws<InvalidArmorException>(() => worrier.AddArmor(testClothHead));

        }

        [Fact]
        public void Item_EquipValidWeapon_ShouldReturnTrue()
        {
            //Arrange
            string expected = "New weapon equipped!";
            Worrier worrier = new Worrier();


            //Act
            string actual = worrier.AddWeapon(testAxeLevel1);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Item_EquipValidArmor_ShouldReturnTrue()
        {
            //Arrange
            string expected = "New armour equipped!";
            Worrier worrier = new Worrier();

            //Act
            string actual = worrier.AddArmor(testPlateBodyLevel1);

            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Item_BaseDamageWithWorrier_ShouldReturnTrue()
        {
            //Arrange
            double expected = 1 * (1 + (5 / 100));
            Worrier worrier = new Worrier();

            //Act
            double actual = worrier.Damage;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Item_DamageWithValidWeaponWorrier_ShouldReturnTrue()
        {
            //Arrange
            double r = (7.0 * 1.1);
            double l = 1.0;
            double tmp = (5.0 / 100.0);
            
            double expected = (7.0 * 1.1) * (1.0 + (5.0 / 100.0));
            Worrier worrier = new Worrier();
            worrier.AddWeapon(testAxeLevel1);

            //Act
            double actual = worrier.Damage;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Item_DamageWithValidWeaponAndArmorWorrier_ShouldReturnTrue()
        {
            //Arrange
            double expected = (7.0 * 1.1) * (1.0 + ((5.0 + 1.0) / 100.0));
            Worrier worrier = new Worrier();
            worrier.AddWeapon(testAxeLevel1);
            worrier.AddArmor(testPlateBodyLevel1);


            //Act
            double actual = worrier.Damage;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
