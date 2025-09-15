namespace CowsAndBulls.Tests
{
    public class CowsAndBullsGameTests
    {
        [Fact]
        public void RangeCheckOfGeneratedNumber()
        {
            // Arrange
            var game = new CowsAndBullsGame();
            // Act
            int generatedNumber = game.GenerateNumber();
            // Assert
            Assert.InRange(generatedNumber, 1234, 9876);
        }
    }
}