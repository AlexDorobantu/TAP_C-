using System;
using calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            var c = new Calculator();
            //Arrange
            double value1 = 3;
            double value2 = 3;
            double result = value1 + value2;
            double result1 = c.Add(value1, value2);

            //Act
            Console.WriteLine("-> TESTING ADD...");

            //Assert
            Assert.AreEqual(result1, result);
        }

        [TestMethod]
        public void TestSubtract()
        {
            var c = new Calculator();
            //Arrange
            double value1 = 5;
            double value2 = 10;
            double result = value1 - value2;
            double result1 = c.Subtract(value1, value2);

            //Act
            Console.WriteLine("-> TESTING Substract...");

            //Assert
            Assert.AreEqual(result1, result);
        }

        [TestMethod]
        public void TestMultiply()
        {
            var c = new Calculator();
            //Arrange
            double value1 = 5;
            double value2 = 10;
            double result = value1 * value2;
            double result1 = c.Multiply(value1, value2);

            //Act
            Console.WriteLine("-> TESTING Multiply...");

            //Assert
            Assert.AreEqual(result1, result);
        }

        [TestMethod]
        public void TestDivide()
        {
            var c = new Calculator();
            //Arrange
            double value1 = 5;
            double value2 = 10;
            double result = value1 / value2;
            double result1 = c.Divide(value1, value2);

            //Act
            Console.WriteLine("-> TESTING Devide...");

            //Assert
            Assert.AreEqual(result1, result);
        }

    }
}
