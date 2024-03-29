﻿using data.classes.interfaces;

namespace Data.interactors.interfaces
{
    public interface IBossInteractor
    {
        public IEntity[] GetEntities();
        public IStatBlock GetStatblock();
        public int GetAttackAttribute();
        public int GetDefenceAttribute();
        public int GetHealthAttribute();
        public int GetLives();
        public int GetRemainingHealth();
        public void SetEntity(IEntity[] entities);
        public void SetStatBlock(IStatBlock statblock);
        public void SetAttackAttribute(int attack);
        public void SetDefence(int defence);
        public void SetHealthAttribute(int value);
        public void SetLives(int lives);
        public void SetRemainingHealth(int value);
    }
}
