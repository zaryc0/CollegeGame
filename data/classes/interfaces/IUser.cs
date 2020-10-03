using Data.classes.entities.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.classes.Objects.interfaces
{
    public interface IUser
    {
        public string GetUserName();
        public void SetUserName(string name);
        public int GetUserId();
        public void SetUserId(int id);
        public int GetScore();
        public void SetScore(int score);
    }
}
