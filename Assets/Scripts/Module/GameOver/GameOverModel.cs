using Agate.MVC.Core;
using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShootShoot.Module.GameOver
{
    public class GameOverModel : BaseModel, IGameOverModel
    {
        public int HighScore { get; private set; }

        public int PlayerScore { get; private set; }

        public void SetHighScore(int hs)
        {
            HighScore = hs;
        }

        public void SetPlayerScore(int ps)
        {
            PlayerScore = ps;
        }

    }
}

