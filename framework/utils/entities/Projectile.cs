using data.classes.interfaces;
using framework.utils.entities.interfaces;
using System;

namespace framework.utils.entities
{
    public class Projectile : IProjectile
    {
        //constructor
        public Projectile()
        {

        }
        //data
        private IEntity _model;
        private int _damage;

        //function
        public int Collide()
        {
            
            return _damage;
        }

        public IEntity GetModel()
        {
            return _model;
        }

        public void SetModel(IEntity model)
        {
            _model = model;
        }
    }
}
