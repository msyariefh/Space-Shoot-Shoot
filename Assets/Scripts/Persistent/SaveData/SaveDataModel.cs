using Agate.MVC.Base;

namespace SpaceShootShoot.Persistent.SaveData
{
    public class SaveDataModel : BaseModel, ISaveDataModel
    {
        public string[] LeaderNames { get; private set; }
        public int[] LeaderScores { get; private set; }

        public void SetLeaderboard(string[] names, int[] scores)
        {
            LeaderNames = names;
            LeaderScores = scores;
            SetDataAsDirty();
        }
    }
}

