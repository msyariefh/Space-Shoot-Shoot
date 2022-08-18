using UnityEngine;

namespace SpaceShootShoot.Message
{
    public struct EnemyShootMessage
    {
        public Vector3 Position { get; }

        public EnemyShootMessage(Vector3 position)
        {
            this.Position = position;
        }
    }
}