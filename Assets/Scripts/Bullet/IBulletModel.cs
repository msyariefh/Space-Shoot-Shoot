using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShootShoot.Module.Bullet
{
    public interface IBulletModel : IBaseModel
    {
        public float Speed { get; }
        public Vector2 Direction { get; }
    }
}