using data.classes.interfaces;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using wrappers.interfaces;

namespace constants
{
    interface BossTemplate
    {
        public int GetNumberOfEntities();
        public IStatBlock GetStatBlock(IDice dice);
    }
    class BeanFiend
    {
        public BeanFiend()
        {

        }

    }
}
