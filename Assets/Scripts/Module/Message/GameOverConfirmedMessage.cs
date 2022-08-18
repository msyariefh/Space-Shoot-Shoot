namespace SpaceShootShoot.Module.Message
{
    public struct GameOverConfirmedMessage
    {
        public string Name { get; private set; }
        public int Score { get; private set; }

        public GameOverConfirmedMessage(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}

