using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShootShoot.Module.Player
{
    public interface IPlayerModel : IBaseModel
    {
        public string Name { get; }
        public float Speed { get; }
        public Vector2 Direction {get; }
    }
}
