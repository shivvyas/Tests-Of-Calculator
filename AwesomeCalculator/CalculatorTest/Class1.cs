using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AwesomeCalculator;

namespace CalculatorTest
{
    public class Class1
    {
        [Test]
        public void GetAddition_Input5point2and3point2_Returns8point4()
        {
            //Arrange 
            double number1 = 5.2; double number2 = 3.2;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input2and2point1_Returns4point1()
        {
            //Arrange 
            double number1 = 2; double number2 = 2.1;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_InputMinus2andMinus1_ReturnsMinus3()
        {
            //Arrange 
            double number1 = -2; double number2 = -1;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_InputMinus3and33_ReturnsMinus36()
        {
            //Arrange 
            double number1 = -3; double number2 = 33;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input0Point22andMinus10_Returns10Point22()
        {
            //Arrange 
            double number1 = 0.22; double number2 = -10;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input0andMinus3_Returns3()
        {
            //Arrange 
            double number1 = 0; double number2 = -3;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input0and2_Returns0()
        {
            //Arrange 
            double number1 = 0; double number2 = 2;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_InputMinus2and3Point5_ReturnsMinus7()
        {
            //Arrange 
            double number1 = -2; double number2 = 3.5;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input100andMinus7_ReturnsMinus700()
        {
            //Arrange 
            double number1 = 100; double number2 = -7;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input0and2_Returns0()
        {
            //Arrange 
            double number1 = 0; double number2 = 2;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input1Dividby3and5_Returns0Point07()
        {
            //Arrange 
            double number1 = 1 / 3; double number2 = 5;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_InputMinus3and10_ReturnsMinus0Point3()
        {
            //Arrange 
            double number1 = -3; double number2 = 10;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
