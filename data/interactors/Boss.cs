using Constants.Enum;
using Data.classes.entities;
using Data.classes.entities.interfaces;

namespace data.classes.entities
{
    public class Boss : IBossInteractor
    {
        private int _healthBar;
        private int _health;
        private int _attack;
        private int _defence;
        private int _lives;
        private int _score;

        public int GetAttackAttribute()
        {
            return _attack;
        }

        public int GetDefenceAttribute()
        {
            return _defence;
        }

        public int GetHealthAttribute()
        {
            return _healthBar;
        }

        public int GetLives()
        {
            return _lives;
        }

        public int GetRemainingHealth()
        {
            return _health;
        }

        public void SetAttackAttribute(int attack)
        {
            _attack = attack;
        }

        public void SetDefence(int defence)
        {
            _defence = defence;
        }

        public void SetHealthAttribute(int value)
        {
            _health = value;
        }

        public void SetLives(int lives)
        {
            _lives = lives;
        }

        public void SetRemainingHealth(int value)
        {
            _health = value;
        }
    }
}

