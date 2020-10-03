using data.classes.interfaces;
using data.interactors.interfaces;
using Data.interactors.interfaces;

namespace data.interactors
{
    public class Creature : ICreatureInteractor
    {
        public IEntity GetEntity()
        {
            throw new System.NotImplementedException();
        }

        public IStatBlock GetStatblock()
        {
            throw new System.NotImplementedException();
        }

        public void SetEntity(IEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void SetStatBlock(IStatBlock statBlock)
        {
            throw new System.NotImplementedException();
        }
    }
}