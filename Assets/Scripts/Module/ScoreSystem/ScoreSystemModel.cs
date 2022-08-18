using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShootShoot.Module.ScoreSystem
{
    public class ScoreSystemModel : BaseModel, IScoreSystemModel
    {
        public int PlayerScore { get; private set; }

        public void SetPlayerScore(int score)
        {
            PlayerScore = score;
            SetDataAsDirty();
        }
    }
}

