using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShootShoot.Module.EnemyBullet
{
    public interface IEnemyBulletModel : IBaseModel
    {
        public float Speed { get; }
        public Vector2 Direction { get; }
    }
}