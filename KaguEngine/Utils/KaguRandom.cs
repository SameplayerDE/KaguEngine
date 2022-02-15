using System;

namespace KaguEngine.Utils
{
    public static class KaguRandom
    {
        private static Random _random;

        static KaguRandom()
        {
            _random = new Random();
        }

        public static int NextInt(int min = int.MinValue, int max = int.MaxValue)
        {
            var result = _random.Next(min, max);
            return result;
        }
        

    }
}