using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShootShoot.Module.Bullet
{
    public class BulletModel : BaseModel, IBulletModel
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