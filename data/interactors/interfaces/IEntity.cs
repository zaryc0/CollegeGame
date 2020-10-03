using Constants.Enum;

namespace Data.classes.entityInteractors.interfaces
{
    public interface IEntity
    {
        public int GetId();
        public void SetId(int id);
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
