using data.classes.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace framework.utils.entities.interfaces
{
    public interface IProjectile
    {
        //data
        public IEntity GetModel();
        public void SetModel(IEntity model);

        //functions
        public int Collide();
    }
}
