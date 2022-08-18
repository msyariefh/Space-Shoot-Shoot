namespace SpaceShootShoot.Module.Message
{
    public struct TotalScoreMessage
    {
        public int TotalScore { get; private set; }

        public TotalScoreMessage(int totalScore)
        {
            TotalScore = totalScore;
        }
    }
}

