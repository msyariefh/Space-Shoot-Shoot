using Agate.MVC.Base;

namespace SpaceShootShoot.Persistent.SaveData
{
    public class SaveDataModel : BaseModel, ISaveDataModel
    {
        public string[] LeaderNames { get; private set; }
        public int[] LeaderScores { get; private set; }

        public void SetLeaderboard(string[] names, int[] scores)
        {
            string[] _names = names;
            int[] _scores = scores;

            System.Array.Sort(_scores, _names);
            System.Array.Reverse(_names);
            System.Array.Reverse(_scores);
            LeaderNames = _names;
            LeaderScores = _scores;
            SetDataAsDirty();
        }
    }
}

