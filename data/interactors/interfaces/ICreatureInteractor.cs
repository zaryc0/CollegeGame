using data.classes.interfaces;
using Data.interactors.interfaces;

namespace data.interactors.interfaces
{
    public interface ICreatureInteractor
    {
        public IEntity GetEntity();
        public IStatBlock GetStatblock();
        public void SetEntity(IEntity entity);
        public void SetStatBlock(IStatBlock statBlock);
    }
}
