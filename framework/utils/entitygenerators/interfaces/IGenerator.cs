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

        public IBossInteractor BossInteractor(IDice dice, IEntity entity, IStatBlock, BOSS_TYPE type);

        public ICreatureInteractor CreatureInteractor(IEntity entity, IDice dice);
    }
}
