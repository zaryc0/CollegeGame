using Data.classes.entityInteractors.interfaces;

namespace data.classes.entityInteractors.interfaces
{
    public interface ICreatureInteractor : IEntity
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
