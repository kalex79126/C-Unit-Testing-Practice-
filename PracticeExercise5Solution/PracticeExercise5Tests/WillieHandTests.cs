using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeExercise5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise5.Tests
{
    [TestClass()]
    public class WillieHandTests
    {
        #region
        /// <summary>
        /// UseCase A1 - Below Lower boundary for card two
        /// ArgumentOutOfRangeException
        /// </summary>
        [TestMethod()]
        public void WillieHandTest2A1()
        {
            //Arrange
            int cardOne = 7;
            int? cardTwo = -1;

            //Act
            try
            {
                WillieHand target = new WillieHand(cardOne, cardTwo);
            }
            catch ( ArgumentOutOfRangeException e)
            {
                //Assert
                StringAssert.Contains(e.Message, WillieHand.CardValueTooLowMessage);
                return;
            }
            Assert.Fail("Failed to get the expected exception.");
        }
        [TestMethod()]
        public void WillieHandTest2A4()
        {
            //Arrange
            int cardOne = 7;
            int? cardTwo = 14;

            //Act
            try
            {
                WillieHand target = new WillieHand(cardOne, cardTwo);
            }
            catch (ArgumentOutOfRangeException e)
            {
                //Assert
                StringAssert.Contains(e.Message, WillieHand.CardValueTooHighMessage);
                return;
            }
            Assert.Fail("Failed to get the expected exception.");
        }
        #endregion
    }
}