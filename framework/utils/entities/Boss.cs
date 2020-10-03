using Data.interactors.interfaces;
using framework.utils.entities.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace framework.utils.entities
{
    class Boss : IBoss
    {
        public Boss()
        {

        }
        public int Attack()
        {
            throw new NotImplementedException();
        }

        public void ChangePhase()
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

        public IBossInteractor GetModel()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int damage)
        {
            throw new NotImplementedException();
        }
    }
}
