using rpg_character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RPGCharactersTests
{
    public class CharacterTests
    {
        [Fact]
        public void Character_CreateLevelOneCharacter_ReturnTrueIfCharacterIsLevelOne()
        {
            //Arrange
            int expected = 1;
            Mage mage = new Mage();

            //Act
            int actual = mage.Level;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Character_CharacterLevelUp_RetrunTrueIfLevelIncreasFromOneToTwo()
        {
            //Arrange
            int expected = 2;
            Mage mage = new Mage();
            mage.levelUp();

            //Act
            int actual = mage.Level;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Character_MageIsCreatedWithRightDefaultAttributes_ReturnTrueIfCorrect()
        {
            //Arrange
            Stats expected = new Stats() { Strength = 1, Dexterity = 1, Intelligence = 8};
            Mage mage = new Mage();

            //Act
            Stats actual = mage.TotalStats;

            //Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }

        [Fact]
        public void Character_RangerIsCreatedWithRightDefaultAttributes_ReturnTrueIfCorrect()
        {
            //Arrange
            Stats expected = new Stats() { Strength = 1, Dexterity = 7, Intelligence = 1 };
            Ranger ranger = new Ranger();

            //Act
            Stats actual = ranger.TotalStats;

            //Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }
        [Fact]
        public void Character_RogueIsCreatedWithRightDefaultAttributes_ReturnTrueIfCorrect()
        {
            //Arrange
            Stats expected = new Stats() { Strength = 2, Dexterity = 6, Intelligence = 1 };
            Rogue rogue = new Rogue();

            //Act
            Stats actual = rogue.TotalStats;

            //Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);
        }
        [Fact]
        public void Character_WorrierIsCreatedWithRightDefaultAttributes_ReturnTrueIfCorrect()
        {
            //Arrange
            Stats expected = new Stats() { Strength = 5, Dexterity = 2, Intelligence = 1 };
            Worrier worrier = new Worrier();

            //Act
            Stats actual = worrier.TotalStats;

            //Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);

        }

        [Fact]
        public void Character_RangerLevelupStatsIncrease_ReturnTrueIfCorrect()
        {
            //Arrange
            Stats expected = new Stats() { Strength = 2, Dexterity = 12, Intelligence = 2 };
            Ranger ranger = new Ranger();
            ranger.levelUp();

            //Act
            Stats actual = ranger.TotalStats;

            //Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);

        }
        [Fact]
        public void Character_RogueLevelupStatsIncrease_ReturnTrueIfCorrect()
        {
            //Arrange
            Stats expected = new Stats() { Strength = 3, Dexterity = 10, Intelligence = 2 };
            Rogue rogue = new Rogue();
            rogue.levelUp();

            //Act
            Stats actual = rogue.TotalStats;

            //Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);

        }
        [Fact]
        public void Character_WorrierLevelupStatsIncrease_ReturnTrueIfCorrect()
        {
            //Arrange
            Stats expected = new Stats() { Strength = 8, Dexterity = 4, Intelligence = 2 };
            Worrier worrier = new Worrier();
            worrier.levelUp();

            //Act
            Stats actual = worrier.TotalStats;

            //Assert
            Assert.Equal(expected.Strength, actual.Strength);
            Assert.Equal(expected.Dexterity, actual.Dexterity);
            Assert.Equal(expected.Intelligence, actual.Intelligence);

        }

    }
}
