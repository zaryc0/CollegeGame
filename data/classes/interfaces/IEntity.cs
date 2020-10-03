namespace data.classes.interfaces
{
    public interface IEntity
    {
        public string GetSpriteAddress();
        public void SetSpriteAddress(string address);
        public int GetSpeedAttribute();
        public void SetSpeedAttribute(int value);
        public (int, int) GetLocation();
        public void SetLocation((int,int) location);
        public bool GetActiveStatus();
        public void SetActiveStatus(bool status);
        public bool GetInteractable();
        public void SetInteractable(bool interaction);
        public int GetDirection();
        public void SetDirection(int direction);
    } 
}
