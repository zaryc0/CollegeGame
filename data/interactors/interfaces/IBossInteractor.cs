namespace Data.classes.entityInteractors.interfaces
{
    public interface IBossInteractor : IEntity
    {
        public int GetAttackAttribute();
        public int GetDefenceAttribute();
        public int GetHealthAttribute();
        public int GetLives();
        public int GetRemainingHealth();
        public void SetAttackAttribute(int attack);
        public void SetDefence(int defence);
        public void SetHealthAttribute(int value);
        public void SetLives(int lives);
        public void SetRemainingHealth(int value);
    }
}
