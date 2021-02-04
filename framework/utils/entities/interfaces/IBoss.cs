using Data.interactors.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace framework.utils.entities.interfaces
{
    public interface IBoss
    {
        //data 
        public IBossInteractor GetModel();

        public IProjectile[] GetAmmo();

        //functions
        public int Attack();
        public void Fire();
        public void TakeDamage(int damage);
        public void ChangePhase();
    }
}
