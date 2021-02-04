using constants;
using data.classes.interfaces;
using framework.utils.entities;
using framework.utils.entities.interfaces;
using framework.utils.entitygenerators.interfaces;
using System;
using wrappers.interfaces;

namespace framework.utils.entitygenerators
{
    class Generator : IGenerator
    {
        public IBoss BossInteractor(IDice dice, IEntity[] entities, IStatBlock statBlock, BOSS_TYPE type)
        {
            switch (type)
            {
                case BOSS_TYPE.BEANFIEND:
                    return BeanFiendTemplate(dice, entities, statBlock);
                case BOSS_TYPE.HUNTER:
                    return HunterTemplate(dice, entities, statBlock);
                case BOSS_TYPE.TROLL:
                    return TrollTemplate(dice, entities, statBlock);
                default: 
                    return new Boss();
            }

        }

        public ICharacter Character(IDice dice, IEntity entity, IStatBlock statBlock, CHARACTER_TYPE type)
        {
            switch (type)
            {
                case CHARACTER_TYPE.TURTLE:
                    return TurtleTemplate(dice, entity, statBlock);
                case CHARACTER_TYPE.UNICORN:
                    return UnicornTemplate(dice, entity, statBlock);
                case CHARACTER_TYPE.FISH:
                    return FishTemplate(dice, entity, statBlock);
                default:
                    return new Character();
            }
        }

        public ICreature CreatureInteractor(IDice dice, IEntity entity, IStatBlock statBlock, CREATURE_TYPE type)
        {
            switch (type)
            {
                case CREATURE_TYPE.FLYER:
                    return FlyerTemplate(dice, entity, statBlock);
                case CREATURE_TYPE.GHOST:
                    return GhostTemplate(dice, entity, statBlock);
                case CREATURE_TYPE.GROUNDED:
                    return GroundedTemplate(dice, entity, statBlock);
                default:
                    return new Creature();
            }
        }

        public IEntity Entity(bool status, bool interactable, int speed, (int, int) location, int direction, string spriteAddress)
        {
            throw new System.NotImplementedException();
        }

        public IProjectile projectile(int damage, IEntity entity, PROJECTILE_TYPE type)
        {
            switch (type)
            {
                case PROJECTILE_TYPE.BUBBLE:
                    return BubbleTemplate(damage, entity);
                case PROJECTILE_TYPE.BEAN:
                    return BeanTemplate(damage, entity);
                case PROJECTILE_TYPE.BULLET:
                    return BulletTemplate(damage, entity);
                case PROJECTILE_TYPE.FIREBALL:
                    return FireBallTemplate(damage, entity);
                case PROJECTILE_TYPE.LASER:
                    return LaserTemplate(damage, entity);
                default:
                    return new Projectile();
            }
        }

        private Projectile LaserTemplate(int damage, IEntity entity)
        {
            throw new NotImplementedException();
        }
        private Projectile FireBallTemplate(int damage, IEntity entity)
        {
            throw new NotImplementedException();
        }
        private Projectile BulletTemplate(int damage, IEntity entity)
        {
            throw new NotImplementedException();
        }
        private Projectile BeanTemplate(int damage, IEntity entity)
        {
            throw new NotImplementedException();
        }
        private Projectile BubbleTemplate(int damage, IEntity entity)
        {
            throw new NotImplementedException();
        }

        private Boss BeanFiendTemplate(IDice dice, IEntity[] entities, IStatBlock statBlock)
        {
            Boss boss = new Boss();
            return boss;
        }
        private Boss TrollTemplate(IDice dice, IEntity[] entities, IStatBlock statBlock)
        {
            Boss boss = new Boss();
            return boss;
        }
        private Boss HunterTemplate(IDice dice, IEntity[] entities, IStatBlock statBlock)
        {
            Boss boss = new Boss();
            return boss;
        }

        private Character TurtleTemplate(IDice dice, IEntity entity, IStatBlock statBlock)
        {
            Character character = new Character();
            return character;
        }
        private Character UnicornTemplate(IDice dice, IEntity entity, IStatBlock statBlock)
        {
            Character character = new Character();
            return character;
        }
        private Character FishTemplate(IDice dice, IEntity entity, IStatBlock statBlock)
        {
            Character character = new Character();
            return character;
        }

        private Creature FlyerTemplate(IDice dice, IEntity entity, IStatBlock statBlock)
        {
            Creature creature = new Creature();
            return creature;
        }
        private Creature GhostTemplate(IDice dice, IEntity entity, IStatBlock statBlock)
        {
            Creature creature = new Creature();
            return creature;
        }
        private Creature GroundedTemplate(IDice dice, IEntity entity, IStatBlock statBlock)
        {
            Creature creature = new Creature();
            return creature;
        }
    }
}

