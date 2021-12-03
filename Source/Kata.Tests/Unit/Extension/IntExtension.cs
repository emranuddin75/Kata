using Kata.Core.Extensions;
using Xunit;

namespace Kata.Tests.Unit.Extension
{
    public class IntExtension
    {
        [Theory]
        [InlineData(1,'A')]
        [InlineData(2,'B')]
        [InlineData(3,'C')]
        [InlineData(4,'D')]
        [InlineData(5,'E')]
        [InlineData(6,'F')]
        [InlineData(7,'G')]
        [InlineData(8,'H')]
        [InlineData(9,'I')]
        [InlineData(10,'J')]
        [InlineData(11,'K')]
        [InlineData(12,'L')]
        [InlineData(13,'M')]
        [InlineData(14,'N')]
        [InlineData(15,'O')]
        [InlineData(16,'P')]
        [InlineData(17,'Q')]
        [InlineData(18,'R')]
        [InlineData(19,'S')]
        [InlineData(20,'T')]
        [InlineData(21,'U')]
        [InlineData(22,'V')]
        [InlineData(23,'W')]
        [InlineData(24,'X')]
        [InlineData(25,'Y')]
        [InlineData(26,'Z')]
        public void ShouldReturnExpectedCharacter(int position, char expected)
        {
            Assert.Equal(expected, position.Character());
        }
    }
}
