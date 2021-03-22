using FindMaximumProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MStestFindMaximum
{
    [TestClass]
    public class UnitTest1
    {
        //Arrange
        MaximumNumberCheck check = new MaximumNumberCheck();
        [TestMethod]
        //Act
        public void Given_MaxNumberAt1StPosition_WhenChecked_ThenReturn_SameNumber()
        {
            int expectedResult = 44;
            int result = MaximumNumberCheck.MaximumIntegerNumber(44, 33, 11);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        //Act
        public void Given_MaxNumberAt2ndPosition_WhenChecked_ThenReturn_SameNumber()
        {
            int expectedResult = 44;
            int result = MaximumNumberCheck.MaximumIntegerNumber(33, 44, 11);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        //Act
        public void Given_MaxNumberAt3rdPosition_WhenChecked_ThenReturn_SameNumber()
        {
            int expectedResult = 44;
            int result = MaximumNumberCheck.MaximumIntegerNumber(33, 11, 44);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        //Act
        public void Given_MaxFloatNumberAt1stPosition_WhenChecked_ThenReturn_SameNumber()
        {
            double expectedResult = 111.44;
            double result = MaximumNumberCheck.MaximumFloatNumber(111.44, 44.20, 33.65);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        //Act
        public void Given_MaxFloatNumberAt2ndPosition_WhenChecked_ThenReturn_SameNumber()
        {
            double expectedResult = 111.44;
            double result = MaximumNumberCheck.MaximumFloatNumber(44.20, 111.44, 33.65);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        //Act
        public void Given_MaxFloatNumberAt3rdPosition_WhenChecked_ThenReturn_SameNumber()
        {
            double expectedResult = 111.44;
            double result = MaximumNumberCheck.MaximumFloatNumber(44.20, 33.65, 111.44);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        //Act
        public void Given_MaxStringAt1stPosition_WhenChecked_ThenReturn_SameNumber()
        {
            string expectedResult = "Carrot";
            string result = MaximumNumberCheck.MaximumStringNumber("Carrot", "Apple", "Banana");
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        //Act
        public void Given_MaxStringAt2ndPosition_WhenChecked_ThenReturn_SameNumber()
        {
            string expectedResult = "Carrot";
            string result = MaximumNumberCheck.MaximumStringNumber("Apple", "Carrot", "Banana");
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        //Act
        public void Given_MaxStringAt3rdPosition_WhenChecked_ThenReturn_SameNumber()
        {
            string expectedResult = "Carrot";
            string result = MaximumNumberCheck.MaximumStringNumber("Apple", "Banana", "Carrot");
            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
