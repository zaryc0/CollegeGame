using System;
using System.Collections.Generic;
using System.Text;

namespace data.classes.interfaces
{
    public interface IStatBlock
    {
        public int GetAttackAttribute();
        public int GetDefenceAttribute();
        public int GetHealthAttribute();
        public int GetRemainingHealth();
        public void SetAttackAttribute(int attack);
        public void SetDefence(int defence);
        public void SetHealthAttribute(int value);
        public void SetRemainingHealth(int value);
    }
}
