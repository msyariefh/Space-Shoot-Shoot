namespace SpaceShootShoot.Module.Message
{
    public struct ScoreChangedMessage 
    {
        public int Score { get; private set; }

        public ScoreChangedMessage(int score)
        {
            Score = score;
        }
    }

}
