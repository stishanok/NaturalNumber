using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using static NaturalNumberLibrary.NaturalNumber;

namespace NaturalNumberLibraryTest
{
    [TestClass]
    public class NaturalNumberTest
    {
        [TestMethod]
        public void CheckNumber_7_ReturnedTrue()
        {
            //arrange
            int number = 7;
            bool expected = true;

            //act
            bool actual = CheckNaturalNumber(number);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckNumber_Minus7_ReturnedFalse()
        {
            //arrange
            int number = -7;
            bool expected = false;

            //act
            bool actual = CheckNaturalNumber(number);

            //assert
            AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateSumDigits_63_Returned9()
        {
            //arrange
            int number = 63;
            int expected = 9;

            //act
            int actual = CalculateSumDigits(number);

            //assert
            AreEqual(expected, actual);
        }

        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void CalculateSumDigits_Minus5_ValidationException()
        {
            //arrange
            int number = -5;

            //act + assert
            CalculateSumDigits(number);
        }

        [TestMethod]
        public void CalculateMulDigits_54_Returned20()
        {
            //arrange
            int number = 54;
            int expected = 20;

            //act
            int actual = CalculateMulDigits(number);

            //assert
            AreEqual(expected, actual);
        }

        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void CalculateMulDigits_Minus45_ValidationException()
        {
            //arrange
            int number = -45;

            //act + assert
            CalculateSumDigits(number);
        }
    }
}