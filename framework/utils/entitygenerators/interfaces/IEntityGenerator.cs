using System;
using System.Collections.Generic;
using System.Text;
using data.classes.interfaces;
using data.interactors.interfaces;
using Data.interactors.interfaces;
using wrappers.interfaces;

namespace framework.utils.entitygenerators.interfaces
{
    public interface IGenerator
    {
        public IEntity Entity(int id);

        public IStatBlock Statblock(IDice dice);

        public ICharacterInteractor CharacterInteractor(IEntity entity,IStatBlock statBlock);

        public IBossInteractor BossInteractor(IEntity[] entities, IDice dice);

        public ICreatureInteractor CreatureInteractor(IEntity entity, IDice dice);

    }
}
