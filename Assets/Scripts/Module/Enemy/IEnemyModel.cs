using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShootShoot.Module.Enemy
{
    public interface IEnemyModel : IBaseModel
    {
        public float Speed { get; }
        public Vector2 Direction {get; }
    }
}
