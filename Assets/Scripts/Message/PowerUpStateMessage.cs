namespace SpaceShootShoot.Message
{
    public struct PowerUpStateMessage 
    {
        public bool IsActive { get; private set; }
        public PowerUpStateMessage(bool isActive)
        {
            IsActive = isActive;
        }
    }
}


