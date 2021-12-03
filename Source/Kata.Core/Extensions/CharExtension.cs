using System;

namespace Kata.Core.Extensions
{
    public static class CharExtension
    {
        private const char LetterA = 'A';

        public static int Position(this char letter)
        {
            return letter - 64;
        }

        public static int MaximumLevels(this char centerLetter)
        {
            var isLetter = Char.IsLetter(centerLetter);
            if (!isLetter) 
            {
                return 0;
            }

            if (centerLetter == LetterA)
            {
                return 1;
            }

            var centerLevel = centerLetter.Position();
            return (centerLevel * 2) - 1;
        }

        public static string Pad(this char letter, int pad)
        {
            return letter.ToString().PadLeft(pad);
        }

        public static int InnerSpacing(this char letter)
        {
            if (letter == LetterA)
                return 0;

            return ((letter.Position() - 1) * 2) - 1;
        }

        public static int OuterSpacing(this char letter, char centerLetter)
        {
            var letterPosition = letter.Position();
            var centerPosition = centerLetter.Position();

            return centerPosition - letterPosition;
        }

        public static string Line(this char letter, char centerLetter)
        {
            string outer;
            var inner = string.Empty;

            switch (letter)
            {
                case 'A':
                    outer = letter.Pad(letter.OuterSpacing(centerLetter) + 1);
                    break;
                default:
                    outer = letter.Pad(letter.OuterSpacing(centerLetter) + 1);
                    inner = letter.Pad(letter.InnerSpacing() + 1);
                    break;
            }

            return $"{outer}{inner}";
        }
    }
}
