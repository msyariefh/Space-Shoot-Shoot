using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShootShoot.Module.EnemyBullet
{
    public class EnemyBulletModel : BaseModel, IEnemyBulletModel
    {
        public float Speed { get; private set;}
        public Vector2 Direction {get; private set; }

        public void SetSpeed(float speed)
        {
            Speed = speed;
            SetDataAsDirty();
        }

        public void SetDirection(Vector2 direction)
        {
            Direction = direction;
            SetDataAsDirty();
        }
    }
}