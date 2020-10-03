using Constants.Enum;
using Data.classes.entities.interfaces;
using Data.classes.entityInteractors.interfaces;
using System;

namespace Data.classes.entities
{
    public class Character : ICharacterInteractor
    {
        private IEntity _entity;
        private int _healthBar;
        private int _health;
        private int _attack;
        private int _defence;
        private int _lives;
        private int _score;
        private int _level;
        private int _exp;

        public bool GetActiveStatus()
        {
            return _entity.GetActiveStatus();
        }

        public int GetAttackAttribute()
        {
            return _attack;
        }

        public int GetDefenceAttribute()
        {
            return _defence;
        }

        public int GetDirection()
        {
            return _entity.GetDirection();
        }

        public int GetExp()
        {
            return _exp;
        }

        public int GetHealthAttribute()
        {
            return _healthBar;
        }

        public int GetId()
        {
            return _entity.GetId();
        }

        public bool GetInteractable()
        {
            return _entity.GetInteractable();
        }

        public int GetLevel()
        {
            return _level;
        }

        public int GetLives()
        {
            return _lives ;
        }

        public (int, int) GetLocation()
        {
            return _entity.GetLocation();
        }

        public int GetRemainingHealth()
        {
            return _health;
        }

        public int GetScore()
        {
            return _score;
        }

        public int GetSpeedAttribute()
        {
            return _entity.GetSpeedAttribute();
        }

        public string GetSpriteAddress()
        {
            return _entity.GetSpriteAddress();
        }

        public void SetActiveStatus(bool status)
        {
            _entity.SetActiveStatus(status);
        }

        public void SetAttackAttribute(int attack)
        {
            _attack = attack;
        }

        public void SetDefence(int defence)
        {
            _defence = defence;
        }

        public void SetDirection(int direction)
        {
            _entity.SetDirection(direction);
        }

        public void SetExp(int experience)
        {
            _exp = experience;
        }

        public void SetHealthAttribute(int value)
        {
            _healthBar = value;
        }

        public void SetId(int id)
        {
            _entity.SetId(id);
        }

        public void SetInteractable(bool interaction)
        {
            _entity.SetInteractable(interaction);
        }

        public void SetLevel(int level)
        {
            _level = level;
        }

        public void SetLives(int lives)
        {
            _lives = lives;
        }

        public void SetLocation((int, int) location)
        {
            _entity.SetLocation(location);
        }

        public void SetRemainingHealth(int value)
        {
            _health = value;
        }

        public void SetScore(int score)
        {
            _score = score;
        }

        public void SetSpeedAttribute(int value)
        {
            _entity.SetSpeedAttribute(value);
        }

        public void SetSpriteAddress(string address)
        {
            _entity.SetSpriteAddress(address);
        }
    }
}
