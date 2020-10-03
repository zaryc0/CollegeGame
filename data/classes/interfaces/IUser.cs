namespace data.classes.interfaces
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
