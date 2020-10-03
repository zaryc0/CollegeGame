using System;
using System.Collections.Generic;
using System.Text;
using data.classes.interfaces;

namespace data.classes
{
    class StatBlock : IStatBlock
    {
        private int _attack;
        private int _defence;
        private int _healthBar;
        private int _health;

        public int GetAttackAttribute()
        {
            throw new NotImplementedException();
        }

        public int GetDefenceAttribute()
        {
            throw new NotImplementedException();
        }

        public int GetHealthAttribute()
        {
            throw new NotImplementedException();
        }

        public int GetRemainingHealth()
        {
            throw new NotImplementedException();
        }

        public void SetAttackAttribute(int attack)
        {
            throw new NotImplementedException();
        }

        public void SetDefence(int defence)
        {
            throw new NotImplementedException();
        }

        public void SetHealthAttribute(int value)
        {
            throw new NotImplementedException();
        }

        public void SetRemainingHealth(int value)
        {
            throw new NotImplementedException();
        }
    }
}
