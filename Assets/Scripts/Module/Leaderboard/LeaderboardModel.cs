using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine;


namespace SpaceShootShoot.Module.Leaderboard
{
    public class LeaderboardModel : BaseModel, ILeaderboardModel
    {
        public int[] Scores { get; private set; }
        public string[] Names { get; private set; }


        public void SetScores(int[] scores)
        {
            Scores = scores;
            SetDataAsDirty();
        }

        public void SetNames(string[] names)
        {
            Names = names;
            SetDataAsDirty();
        }
    }
}

