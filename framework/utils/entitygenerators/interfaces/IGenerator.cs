using constants;
using data.classes.interfaces;
using data.interactors.interfaces;
using Data.interactors.interfaces;
using framework.utils.entities.interfaces;
using wrappers.interfaces;

namespace framework.utils.entitygenerators.interfaces
{
    public interface IGenerator
    {
        public IEntity Entity(bool status, bool interactable, int speed, 
            (int, int) location, int direction, string spriteAddress);
        public IProjectile projectile (int damage, IEntity entity, PROJECTILE_TYPE type);

        public ICharacter Character(IDice dice, IEntity entity, IStatBlock statBlock, CHARACTER_TYPE type);

        public IBoss BossInteractor(IDice dice, IEntity[] entities, IStatBlock statBlock, BOSS_TYPE type);

        public ICreature CreatureInteractor(IDice dice, IEntity entity, IStatBlock statBlock, CREATURE_TYPE type);
    }
}
