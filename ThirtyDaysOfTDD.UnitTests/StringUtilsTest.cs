using NUnit.Framework;

namespace ThirtyDaysOfTDD.UnitTests
{
    [TestFixture]
    public class StringUtilsTest
    {
        private StringUtils _stringUtils;

        [OneTimeSetUp]
        public void SetupStringUtilTests()
        {
            _stringUtils = new StringUtils();
        }

        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInSimpleSentence()
        {
            // arrange
            var sentenceToScan = "TDD is awesome!";
            var characterToScanFor = "e";
            var expectedResult = 2;

            // act
            int result = _stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInComplexSentence()
        {
            // arrange
            var sentenceToScan = "Once is unique, twice is a coincidence, three times is a pattern.";
            var characterToScanFor = "n";
            var expectedResult = 5;

            // act
            int result = _stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldGetAnExceptionWhenCharacterToScanForIsLargerThanOneCharacter()
        {
            // arrange
            var sentenceToScan = "This test should throw an exception";
            var characterToScanFor = "xx";

            // assert
            Assert.That(() => _stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor), Throws.ArgumentException);
        }
    }
}