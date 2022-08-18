using UnityEngine;

namespace SpaceShootShoot.Message
{
    public struct PlayerShootMessage
    {
        public Vector3 Position { get; }

        public PlayerShootMessage(Vector3 position)
        {
            this.Position = position;
        }
    }
}