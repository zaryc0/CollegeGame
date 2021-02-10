namespace data.classes.interfaces
{
    public interface IUser
    {
        public string GetUserName();
        public void SetUserName(string name);
        public int GetScore();
        public void SetScore(int score);
        public ICharacter GetCharacter();
        public void SetCharacter(ICharacter character);
    }
}
