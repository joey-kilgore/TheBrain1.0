using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBrainTest1._0
{
    static class RandomNums
    {
        static Random random = new Random();

        public static int nextInt(int lowerBound, int higherBound)
        {
            return random.Next(lowerBound, higherBound);
        }

        public static double nextDouble(double lowerBound, int higherBound)
        {
            return random.NextDouble() * (higherBound - lowerBound) + lowerBound;
        }



        //public static int nextIntGaussian()
    }
}
