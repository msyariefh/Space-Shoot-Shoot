using UnityEngine;
using Agate.MVC.Base;

namespace SpaceShootShoot.Module.EnemyPool
{
    public interface IEnemyPoolModel : IBaseModel
    {
        public bool IsPlaying { get; }
        public Vector2 Direction { get; }
        public Vector3 SpawnPoint { get; }
        public Vector3 Position { get; }
        public Vector3 DespawnPosition { get; }
    }
}
