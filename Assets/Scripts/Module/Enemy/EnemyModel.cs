using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShootShoot.Module.Enemy
{
    public class EnemyModel : BaseModel, IEnemyModel
    {
        public float Speed { get; }
        public Vector2 Direction { get; private set; } = Vector2.right;

        public void SetDirection(Vector2 direction)
        {
            Direction = direction;
            SetDataAsDirty();
        }
    }
}