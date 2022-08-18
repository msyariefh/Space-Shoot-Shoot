using Agate.MVC.Base;

namespace SpaceShootShoot.Module.ScoreSystem
{
    public interface IScoreSystemModel : IBaseModel
    {
        public int PlayerScore { get; }
    }
}

