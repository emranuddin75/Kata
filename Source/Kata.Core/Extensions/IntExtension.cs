namespace Kata.Core.Extensions
{
    public static class IntExtension
    {
        public static char Character(this int position)
        {
            return (char)(position + 64);
        }
    }
}
