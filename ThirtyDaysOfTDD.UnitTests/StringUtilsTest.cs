using NUnit.Framework;

namespace ThirtyDaysOfTDD.UnitTests
{
    [TestFixture]
    public class StringUtilsTest
    {
        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInSimpleSentence()
        {
            // arrange
            var sentenceToScan = "TDD is awesome!";
            var characterToScanFor = "e";
            var expectedResult = 2;
            var stringUtils = new StringUtils();

            // act
            int result = stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);

            // assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}