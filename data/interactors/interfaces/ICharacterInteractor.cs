using Data.classes.entityInteractors.interfaces;

namespace Data.classes.entities.interfaces
{
    public interface ICharacterInteractor : IEntity
    {
        public int GetAttackAttribute();
        public int GetDefenceAttribute();
        public int GetExp();
        public int GetHealthAttribute();
        public int GetLevel();
        public int GetLives();
        public int GetRemainingHealth();
        public int GetScore();
        public void SetAttackAttribute(int attack);
        public void SetDefence(int defence);
        public void SetExp(int experience);
        public void SetHealthAttribute(int value);
        public void SetLevel(int level);
        public void SetLives(int lives);
        public void SetRemainingHealth(int value);
        public void SetScore(int score);
    }
}
