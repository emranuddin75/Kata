using System;
using Kata.Core;
using Kata.Core.Diamond;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var character = char.Parse(args[0]);
            IKata diamond = new AlphabetDiamondKata(character);
            diamond.Create();
            Console.WriteLine(diamond.OutPut());
        }
    }
}
