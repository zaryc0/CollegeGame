using Data.interfaces;

namespace Data.classes
{
    class User : IUser
    {
        private int _score;
        private int _id;
        private string _userName;
        private IEntity _entity;

        public User()
        {
            _score = 0;
            _id = 0;
            _userName = "Default";
            EntityGenerator.create();
        }
        public User(int id, string userName)
        {
            _score = 0;
            _id = id;
            _userName = userName;
        }

        public IEntity GetEntity()
        {
            throw new System.NotImplementedException();
        }

        public int GetScore()
        {
            return _score;
        }

        public int GetUserId()
        {
            return _id;
        }

        public string GetUserName()
        {
            return _userName;
        }

        public void SetEntity(IEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void SetScore(int score)
        {
            _score = score;
        }

        public void SetUserId(int id)
        {
            _id = id;
        }

        public void SetUserName(string name)
        {
            _userName = name;
        }
    }
}
