using data.interactors.interfaces;
using framework.utils.entities.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace framework.utils.entities
{
    class Creature : ICreature
    {

        public Creature()
        {

        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public ICreatureInteractor GetModel()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(int damage)
        {
            throw new NotImplementedException();
        }
    }
}
