using UnityEngine;

namespace SpaceShootShoot.Message
{
    public struct MovePlayerMessage
    {
        public Vector2 Direction { get; private set; }
        
        public MovePlayerMessage(Vector2 direction) 
        {
            Direction = direction;
        }
    }
}