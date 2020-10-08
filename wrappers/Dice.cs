using System;
using wrappers.interfaces;

namespace wrappers
{
    public class Dice : IDice
    {
        private Random r = new Random();
        public int D100()
        {
            return r.Next(1, 100);
        }
        public int D20()
        {
            return r.Next(1, 20);
        }
        public int D12()
        {
            return r.Next(1, 12);
        }
        public int D10()
        {
            return r.Next(1, 10);
        }
        public int D8()
        {
            return r.Next(1, 8);
        }
        public int D6()
        {
            return r.Next(1, 6);
        }
        public int D2()
        {
            if (D100()%2==0)
            {
            return 2;
            }
            else
            {
                return 1;
            }
        }
    }
}
