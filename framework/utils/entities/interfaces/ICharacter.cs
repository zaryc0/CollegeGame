using Data.interactors.interfaces;

namespace framework.utils.entities.interfaces
{
    public interface ICharacter
    {
        //data 
        public ICharacterInteractor GetModel();
        public void SetModel(ICharacterInteractor model);
        public IProjectile[] GetAmmo();
        public void setAmmo(IProjectile bean);

        //functions
        public int Attack();
        public void Fire();
        public void Hurt(int damage);
        public void move();
        public void reload();
        public void LevelUP();
        public void IncreasScore(int score);
    }
}