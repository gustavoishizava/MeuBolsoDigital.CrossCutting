using MeuBolsoDigital.CrossCutting.Extensions;

namespace MeuBolsoDigital.CrossCutting.UnitTests.Extensions
{
    public class StringExtensionTests
    {
        [Fact]
        public void StringSplit_ReturnArray()
        {
            // Arrange
            var quantityElements = new Random().Next(5, 20);
            var originalList = new List<string>();
            for (var i = 0; i < quantityElements; i++)
                originalList.Add(Guid.NewGuid().ToString());

            var value = string.Join(Environment.NewLine, originalList);

            // Act
            var result = value.ConvertToArray();

            // Assert
            Assert.Equal(originalList.Count, result.Count());
        }
    }
}