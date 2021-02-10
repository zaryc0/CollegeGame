namespace data.classes.interfaces
{
    public interface ICharacter
    {
        public string GetId();
        public void SetId(string Id);
        public string GetSprite();
        public void SetSprite();
        public (int, int) GetSize();
        public void SetSize(int Height, int Width);

    }
}