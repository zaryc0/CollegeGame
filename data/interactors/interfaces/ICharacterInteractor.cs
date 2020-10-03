using data.classes.interfaces;

namespace Data.interactors.interfaces
{
    public interface ICharacterInteractor
    {
        public IEntity GetEntity();
        public IStatBlock GetStatblock();
        public int GetExp();
        public int GetLevel();
        public int GetLives();
        public int GetScore();
        public void SetEntity(IEntity entity);
        public void SetStatBlock(IStatBlock statBlock);
        public void SetExp(int experience);
        public void SetLevel(int level);
        public void SetLives(int lives);
        public void SetScore(int score);
    }
}
