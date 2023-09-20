﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingEx1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingEx1.Tests
{
    [TestClass()]
    public class WillieHandTests
    {
        #region Exerciese 1 - Part A
        /// <summary>
        /// Use Case A1- Nine and Jack, Expect Willie of 19
        /// </summary>
        [TestMethod()]
        public void WillieHandTestA1()
        {
            //Arrange
            int card1 = 9;
            int card2 = 11;
            WillieHand target = new WillieHand(card1, card2);
            int expected = 19;

            //Act
            int actual = target.Willie;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Use Case A2- Ace and Queen, Expect Willie of 11
        /// </summary>
        [TestMethod()]
        public void WillieHandTestA2()
        {
            //Arrange
            int card1 = 1;
            int card2 = 12;
            WillieHand target = new WillieHand(card1, card2);
            int expected = 11;

            //Act
            int actual = target.Willie;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Use Case A3- King and Jack, Expect Willie of 20
        /// </summary>
        [TestMethod()]
        public void WillieHandTestA3()
        {
            //Arrange
            int card1 = 13;
            int card2 = 11;
            WillieHand target = new WillieHand(card1, card2);
            int expected = 20;

            //Act
            int actual = target.Willie;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Use Case A4- 7 and 2, Expect Willie of 9
        /// </summary>
        [TestMethod()]
        public void WillieHandTestA4()
        {
            //Arrange
            int card1 = 7;
            int card2 = 2;
            WillieHand target = new WillieHand(card1, card2);
            int expected = 9;

            //Act
            int actual = target.Willie;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Use Case A5- Queen and 9, Expect Willie of 19
        /// </summary>
        [TestMethod()]
        public void WillieHandTestA5()
        {
            //Arrange
            int card1 = 12;
            int card2 = 9;
            WillieHand target = new WillieHand(card1, card2);
            int expected = 19;

            //Act
            int actual = target.Willie;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Use Case A6- 10 and King, Expect Willie of 20
        /// </summary>
        [TestMethod()]
        public void WillieHandTestA6()
        {
            //Arrange
            int card1 = 10;
            int card2 = 13;
            WillieHand target = new WillieHand(card1, card2);
            int expected = 20;

            //Act
            int actual = target.Willie;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region Exercise 1 - Part B
        /// <summary>
        /// Use Case B7 - Jack and null, Expect Willie of 10
        /// </summary>
        [TestMethod()]
        public void WillieHandTestB7()
        {
            //Arrange
            int card1 = 11;
            int? card2 = null;
            WillieHand target = new WillieHand(card1, card2);
            int expected = 10;

            //Act
            int actual = target.Willie;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}