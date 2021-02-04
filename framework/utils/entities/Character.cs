using Data.interactors.interfaces;
using framework.utils.entities.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace framework.utils.entities
{
    class Character : ICharacter
    {
        public Character()
        {

        }

        public int Attack()
        {
            throw new NotImplementedException();
        }

        public void Fire()
        {
            throw new NotImplementedException();
        }

        public IProjectile[] GetAmmo()
        {
            throw new NotImplementedException();
        }

        public ICharacterInteractor GetModel()
        {
            throw new NotImplementedException();
        }

        public void Hurt(int damage)
        {
            throw new NotImplementedException();
        }

        public void IncreasScore(int score)
        {
            throw new NotImplementedException();
        }

        public void LevelUP()
        {
            throw new NotImplementedException();
        }

        public void move()
        {
            throw new NotImplementedException();
        }

        public void reload()
        {
            throw new NotImplementedException();
        }

        public void setAmmo(IProjectile bean)
        {
            throw new NotImplementedException();
        }

        public void SetModel(ICharacterInteractor model)
        {
            throw new NotImplementedException();
        }
    }
}
