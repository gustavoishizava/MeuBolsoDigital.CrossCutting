using MeuBolsoDigital.CrossCutting.Extensions;

namespace MeuBolsoDigital.CrossCutting.UnitTests.Extensions
{
    public class IEnumerableExtensionsTests
    {
        [Fact]
        public void IsNull_ReturnTrue()
        {
            // Arrange
            List<int> list = null;

            // Act
            var result = list.IsNullOrEmpty();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsEmpty_ReturnTrue()
        {
            // Arrange
            List<int> list = new();

            // Act
            var result = list.IsNullOrEmpty();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsNotNullOrEmpty_ReturnFalse()
        {
            // Arrange
            List<int> list = new() { 1 };

            // Act
            var result = list.IsNullOrEmpty();

            // Assert
            Assert.False(result);
        }
    }
}