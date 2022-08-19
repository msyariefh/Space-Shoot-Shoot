namespace SpaceShootShoot.Module.Message
{
    public struct GameOverMessage
    {
        public int PlayerScore { get; private set; }

        public GameOverMessage(int playerScore)
        {
            PlayerScore = playerScore;
        }
    }
}

