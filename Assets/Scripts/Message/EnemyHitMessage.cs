using UnityEngine;

namespace SpaceShootShoot.Message
{
    public struct EnemyHitMessage
    {
        public int ScoreDropped { get; private set; }

        public EnemyHitMessage(int score)
        {
            ScoreDropped = score;
        }
    }
}