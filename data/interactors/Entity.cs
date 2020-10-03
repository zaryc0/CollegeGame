using Constants.Enum;
using Data.classes.entities.interfaces;

namespace Data.classes.entities
{
    public class Entity : IEntity
    {
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

        public int GetDirection()
        {
            return _direction;
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

        public void SetDirection(int direction)
        {
            _direction = direction;
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
