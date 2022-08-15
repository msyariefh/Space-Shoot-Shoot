using Agate.MVC.Base;

namespace SpaceShootShoot.Persistent.SaveData
{
    public interface ISaveDataModel : IBaseModel
    {
        public string[] LeaderNames { get; }
        public int[] LeaderScores { get; }
    }
}
