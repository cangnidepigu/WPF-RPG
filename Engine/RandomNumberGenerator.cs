using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        private static readonly Random _simpleGenerator = new Random();

        public static int NumberBetween(int minimumValue, int maxiumValue)
        {
            return _simpleGenerator.Next(minimumValue, maxiumValue + 1);
        }
    }
}
