using System;
using Kata.Core.Extensions;

namespace Kata.Core.Diamond
{
    public class AlphabetDiamondKata : Kata
    {
        private char CenterLetter { get; }

        public AlphabetDiamondKata(char center)
        {
            var isLetter = Char.IsLetter(center);

            if (isLetter)
            {
                CenterLetter = char.ToUpper(center);
            }

            Lines = new string[51];
        }

        public override string[] Create()
        {
            if (string.IsNullOrEmpty(CenterLetter.ToString()))
            {
                return Lines;
            }
            
            var centerPosition = CenterLetter.Position();
            var bottomPosition = CenterLetter.MaximumLevels();

            for (int i =0; i < centerPosition; i++)
            {
                var topPosition = i + 1 ;
                var currentLetter = topPosition.Character();

                if (currentLetter == CenterLetter)
                {
                    Lines[topPosition - 1] = currentLetter.Line(CenterLetter);
                }
                else
                {
                    Lines[topPosition -1] = currentLetter.Line(CenterLetter);
                    Lines[bottomPosition - 1] = currentLetter.Line(CenterLetter);

                    bottomPosition -= 1;
                }
            }
            return Lines;
        }
    }
}
