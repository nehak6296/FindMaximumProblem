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
    }
}
