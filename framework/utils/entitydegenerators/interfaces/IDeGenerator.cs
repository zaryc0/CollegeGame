using data.classes.interfaces;
using framework.utils.entities.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace framework.utils.entitydegenerators.interfaces
{
    interface IDeGenerator
    {
        public void Entity(IEntity entity);

        public void Projectile(IProjectile projectile);

        public void Character(ICharacter character);

        public void BossInteractor(IBoss boss);

        public void CreatureInteractor(ICreature creature);
    }
}
