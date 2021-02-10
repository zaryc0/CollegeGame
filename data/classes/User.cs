using data.classes.interfaces;

namespace Data.classes
{
    class User : IUser
    {
        private int _score;
        private string _userName;

        public User()
        {
            _score = 0;
            _userName = "Default";
        }
        public User(string userName)
        {
            _score = 0;
            _userName = userName;
        }

        public int GetScore()
        {
            return _score;
        }

        public string GetUserName()
        {
            return _userName;
        }

        public void SetScore(int score)
        {
            _score = score;
        }

        public void SetUserName(string name)
        {
            _userName = name;
        }
    }
}
