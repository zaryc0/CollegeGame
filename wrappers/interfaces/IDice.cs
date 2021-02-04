using System;
using System.Collections.Generic;
using System.Text;

namespace wrappers.interfaces
{
    public interface IDice
    {
        public int D100();
        public int D20();
        public int D12();
        public int D10();
        public int D8();
        public int D6();
        public int D2();
    }
}
