using data.classes.interfaces;
using data.interactors.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace framework.utils.entities.interfaces
{
    public interface ICreature
    {
        // Data
        public ICreatureInteractor GetModel();

        //functions
        public void Move();
        public void Attack();
        public void TakeDamage(int damage);
    }
}
