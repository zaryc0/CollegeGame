using Constants.Enum;
using data.classes.entities.interfaces;
using data.classes.entityInteractors.interfaces;
using Data.classes.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace data.classes.entities
{
    public class Creature : ICreatureInteractor
    {
        private int _healthBar;
        private int _health;
        private int _attack;
        private int _defence;
        private bool _activeStatus;
        private bool _interactable;
        private int _id;
        private int _speed;
        private (int, int) _location;
        private int _direction;
        private string _spriteAddress;

        public bool GetActiveStatus()
        {
            return _activeStatus;
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
            return _direction;
        }

        public int GetHealthAttribute()
        {
            return _healthBar;
        }

        public int GetId()
        {
            return _id;
        }

        public bool GetInteractable()
        {
            return _interactable;
        }

        public (int, int) GetLocation()
        {
            return _location;
        }

        public int GetRemainingHealth()
        {
            return _health;
        }

        public int GetSpeedAttribute()
        {
            return _speed;
        }

        public string GetSpriteAddress()
        {
            return _spriteAddress;
        }

        public void SetActiveStatus(bool status)
        {
            _activeStatus = status;
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
            _direction = direction;
        }

        public void SetHealthAttribute(int value)
        {
            _healthBar = value;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public void SetInteractable(bool interaction)
        {
            _interactable = interaction;
        }

        public void SetLocation((int, int) location)
        {
            _location = location;
        }

        public void SetRemainingHealth(int value)
        {
            _health = value;
        }

        public void SetSpeedAttribute(int value)
        {
            _speed = value;
        }

        public void SetSpriteAddress(string address)
        {
            _spriteAddress = address;
        }
    }
}
