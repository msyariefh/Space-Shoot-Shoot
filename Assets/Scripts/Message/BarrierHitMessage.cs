using UnityEngine;

namespace SpaceShootShoot.Message
{
    public struct BarrierHitMessage
    {
        public string Name { get; }

        public BarrierHitMessage(string name)
        {
            this.Name = name;
        }
    }
}