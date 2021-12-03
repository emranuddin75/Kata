using Kata.Core.Extensions;
using Xunit;

namespace Kata.Tests.Unit.Extension
{
    public class CharExtension
    {
        [Theory]
        [InlineData('A', 1)]
        [InlineData('B', 2)]
        [InlineData('C', 3)]
        [InlineData('D', 4)]
        [InlineData('E', 5)]
        [InlineData('F', 6)]
        [InlineData('G', 7)]
        [InlineData('H', 8)]
        [InlineData('I', 9)]
        [InlineData('J', 10)]
        [InlineData('K', 11)]
        [InlineData('L', 12)]
        [InlineData('M', 13)]
        [InlineData('N', 14)]
        [InlineData('O', 15)]
        [InlineData('P', 16)]
        [InlineData('Q', 17)]
        [InlineData('R', 18)]
        [InlineData('S', 19)]
        [InlineData('T', 20)]
        [InlineData('U', 21)]
        [InlineData('V', 22)]
        [InlineData('W', 23)]
        [InlineData('X', 24)]
        [InlineData('Y', 25)]
        [InlineData('Z', 26)]
        public void ShouldReturnExpectedPosition(char letter, int expected)
        {
            Assert.Equal(expected, letter.Position());
        }

        [Theory]
        [InlineData('B', 3)]
        [InlineData('C', 5)]
        [InlineData('D', 7)]
        [InlineData('E', 9)]
        [InlineData('F', 11)]
        [InlineData('G', 13)]
        [InlineData('H', 15)]
        [InlineData('I', 17)]
        [InlineData('J', 19)]
        [InlineData('K', 21)]
        [InlineData('L', 23)]
        [InlineData('M', 25)]
        [InlineData('N', 27)]
        [InlineData('O', 29)]
        [InlineData('P', 31)]
        [InlineData('Q', 33)]
        [InlineData('R', 35)]
        [InlineData('S', 37)]
        [InlineData('T', 39)]
        [InlineData('U', 41)]
        [InlineData('V', 43)]
        [InlineData('W', 45)]
        [InlineData('X', 47)]
        [InlineData('Y', 49)]
        [InlineData('Z', 51)]
        public void ShouldReturnExpectedHeight(char center, int expected)
        {
            Assert.Equal(expected, center.MaximumLevels());
        }

        [Theory]
        [InlineData('£', 0)]
        [InlineData('1', 0)]
        [InlineData('>', 0)]
        public void ShouldNotReturnExpectedHeight(char center, int expected)
        {
            Assert.Equal(expected, center.MaximumLevels());
        }

        [Theory]
        [InlineData('A', 0)]
        [InlineData('B', 1)]
        [InlineData('C', 3)]
        [InlineData('D', 5)]
        [InlineData('E', 7)]
        [InlineData('F', 9)]
        [InlineData('G', 11)]
        [InlineData('H', 13)]
        [InlineData('I', 15)]
        [InlineData('J', 17)]
        [InlineData('K', 19)]
        [InlineData('L', 21)]
        [InlineData('M', 23)]
        [InlineData('N', 25)]
        [InlineData('O', 27)]
        [InlineData('P', 29)]
        [InlineData('Q', 31)]
        [InlineData('R', 33)]
        [InlineData('S', 35)]
        [InlineData('T', 37)]
        [InlineData('U', 39)]
        [InlineData('V', 41)]
        [InlineData('W', 43)]
        [InlineData('X', 45)]
        [InlineData('Y', 47)]
        [InlineData('Z', 49)]
        public void ShouldReturnExpectedInnerSpacing(char letter, int expected)
        {
            Assert.Equal(expected, letter.InnerSpacing());
        }


        [Theory]
        [InlineData('Z', 'A', 25)]
        [InlineData('Z', 'B', 24)]
        [InlineData('Z', 'C', 23)]
        [InlineData('Z', 'D', 22)]
        [InlineData('Z', 'E', 21)]
        [InlineData('Z', 'F', 20)]
        [InlineData('Z', 'G', 19)]
        [InlineData('Z', 'H', 18)]
        [InlineData('Z', 'I', 17)]
        [InlineData('Z', 'J', 16)]
        [InlineData('Z', 'K', 15)]
        [InlineData('Z', 'L', 14)]
        [InlineData('Z', 'M', 13)]
        [InlineData('Z', 'N', 12)]
        [InlineData('Z', 'O', 11)]
        [InlineData('Z', 'P', 10)]
        [InlineData('Z', 'Q', 9)]
        [InlineData('Z', 'R', 8)]
        [InlineData('Z', 'S', 7)]
        [InlineData('Z', 'T', 6)]
        [InlineData('Z', 'U', 5)]
        [InlineData('Z', 'V', 4)]
        [InlineData('Z', 'W', 3)]
        [InlineData('Z', 'X', 2)]
        [InlineData('Z', 'Y', 1)]
        [InlineData('Z', 'Z', 0)]
        public void ShouldReturnExpectedOuterSpacing(char centerLetter, char letter, int expected)
        {
            Assert.Equal(expected, letter.OuterSpacing(centerLetter));
        }

        [Theory]
        [InlineData('Z', 'A', "                         A")]
        [InlineData('Z', 'B', "                        B B")]
        [InlineData('Z', 'C', "                       C   C")]
        [InlineData('Z', 'D', "                      D     D")]
        [InlineData('Z', 'E', "                     E       E")]
        [InlineData('Z', 'F', "                    F         F")]
        [InlineData('Z', 'G', "                   G           G")]
        [InlineData('Z', 'H', "                  H             H")]
        [InlineData('Z', 'I', "                 I               I")]
        [InlineData('Z', 'J', "                J                 J")]
        [InlineData('Z', 'K', "               K                   K")]
        [InlineData('Z', 'L', "              L                     L")]
        [InlineData('Z', 'M', "             M                       M")]
        [InlineData('Z', 'N', "            N                         N")]
        [InlineData('Z', 'O', "           O                           O")]
        [InlineData('Z', 'P', "          P                             P")]
        [InlineData('Z', 'Q', "         Q                               Q")]
        [InlineData('Z', 'R', "        R                                 R")]
        [InlineData('Z', 'S', "       S                                   S")]
        [InlineData('Z', 'T', "      T                                     T")]
        [InlineData('Z', 'U', "     U                                       U")]
        [InlineData('Z', 'V', "    V                                         V")]
        [InlineData('Z', 'W', "   W                                           W")]
        [InlineData('Z', 'X', "  X                                             X")]
        [InlineData('Z', 'Y', " Y                                               Y")]
        [InlineData('Z', 'Z', "Z                                                 Z")]
        public void ShouldReturnExpectedLine(char centerLetter, char letter, string expected)
        {
            Assert.Equal(expected, letter.Line(centerLetter));
        }

    }
}
