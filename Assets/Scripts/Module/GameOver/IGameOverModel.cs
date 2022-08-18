using Agate.MVC.Core;
using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShootShoot.Module.GameOver
{
    public interface IGameOverModel : IBaseModel
    {
        public int HighScore { get; }
        public int PlayerScore { get; }
    }
}


