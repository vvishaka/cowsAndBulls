namespace CowsAndBulls.Tests
{
    public class CowsAndBullsGame
    {
        private readonly Random _random;

        public CowsAndBullsGame()
        {
            _random = new Random();
        }

        public int GenerateNumber()
        {
            return _random.Next(1234, 9877);
        }

        public bool CheckNoRepeats(int validNumber)
        {
            
            return true;
        }
    }

    public class CowsAndBullsGameTests
    {
        [Fact]
        public void When_1234_PassedToCheckRepeats_Should_Return_True()
        {
            // Arrange
            var game = new CowsAndBullsGame();
            int validNumber = 1234; // Example of a valid number

            // Act
            bool result = game.CheckNoRepeats(validNumber);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void When_1224_PassedToCheckRepeats_Should_Return_False()
        {
            // Arrange
            var game = new CowsAndBullsGame();
            int validNumber = 1224; // Example of a valid number

            // Act
            bool result = game.CheckNoRepeats(validNumber);

            // Assert
            Assert.False(result);
        }
    }
}