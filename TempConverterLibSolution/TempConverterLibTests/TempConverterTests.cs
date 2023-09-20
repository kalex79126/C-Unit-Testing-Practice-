using Microsoft.VisualStudio.TestTools.UnitTesting;
using TempConverterLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverterLib.Tests
{
    #region Part A

    [TestClass()]
    public class TempConverterTests
    {
        /// <summary>
        /// Case A1 Given 1000 Celsius, expect 1273.15 Kelvin or 1832 Fahrenheit
        /// </summary>
        [TestMethod()]
        public void TempConverterTestA1Celsius()
        {
            //Arrange 
            decimal givenC = 1000m;
            decimal expectedK = 1273.15m;
            decimal expectedF = 1832m;
            TempConverter target = new TempConverter(givenC, SysOfUnits.Celsius);

            //Act
            decimal actualK = target.InKelvin;
            decimal actualF = target.InFahrenheit;

            //Assert
            Assert.AreEqual(expectedK, actualK, "Failed for Kelvin");
            Assert.AreEqual(expectedF, actualF, "Failed for Fahrenheit");
        }

        [TestMethod()]
        public void TempConverterTestA4Fahrenheit()
        {
            //Arrange 
            decimal givenF = 32m;
            decimal expectedK = 273.15m;
            decimal expectedC = 0m;
            TempConverter target = new TempConverter(givenF, SysOfUnits.Celsius);

            //Act
            decimal actualK = target.InKelvin;
            decimal actualC = target.InCelcius;

            //Assert
            Assert.AreEqual(expectedK, actualK, "Failed for Kelvin");
            Assert.AreEqual(expectedC, actualC, "Failed for Celsius");
        }

        #endregion
        #region Part B
        /// <summary>
        /// Case B1 Below Absolute Zero Celsius
        /// </summary>
        [TestMethod()]
        public void TempConverterTestB1CelsiusBelow()
        {
            //Arrange 
            decimal givenC = -273.15m - 0.001m;

            //Act
            try
            {
                TempConverter target = new TempConverter(givenC, SysOfUnits.Celsius);
            }
            catch(ArgumentOutOfRangeException)
            {
                //Assert, we got the exception we expected
                return;
            }

            //Assert
            Assert.Fail("You could not get this far");
        }
        /// <summary>
        /// Case B2 At Absolute Zero Celsius
        /// </summary>
        [TestMethod()]
        public void TempConverterTestB2Celsius()
        {
            //Arrange 
            decimal givenC = -273.15m;
            decimal expectedK = 0m;
            decimal expectedF = -459.67m;
            TempConverter target = new TempConverter(givenC, SysOfUnits.Celsius);

            //Act
            decimal actualK = target.InKelvin;
            decimal actualF = target.InFahrenheit;

            //Assert
            Assert.AreEqual(expectedF, actualF, "Failed for Fahrenheit");
            Assert.AreEqual(expectedK, actualK, "Failed for Kelvin");
        }

        /// <summary>
        /// Case B3 Below Absolute Zero Kelvin
        /// </summary>
        [TestMethod()]
        public void TempConverterTestB3KelvinBelow()
        {
            //Arrange 
            decimal givenK = -0.001m;

            //Act
            try
            {
                TempConverter target = new TempConverter(givenK, SysOfUnits.Kelvin);
            }
            catch (ArgumentOutOfRangeException)
            {
                //Assert, we got the exception we expected
                return;
            }

            //Assert
            Assert.Fail("You could not get this far");
        }

        /// <summary>
        /// Case B4 At Absolute Zero Kelvin
        /// </summary>
        [TestMethod()]
        public void TempConverterTestB4Kelvin()
        {
            //Arrange 
            decimal givenK = 0m;
            decimal expectedC = -273.15m;
            decimal expectedF = -459.67m;
            TempConverter target = new TempConverter(givenK, SysOfUnits.Kelvin);

            //Act
            decimal actualC = target.InCelcius;
            decimal actualF = target.InFahrenheit;

            //Assert
            Assert.AreEqual(expectedF, actualF, "Failed for Fahrenheit");
            Assert.AreEqual(expectedC, actualC, "Failed for Celsius");
        }
        #endregion
    }
}