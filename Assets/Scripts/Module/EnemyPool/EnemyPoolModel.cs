using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShootShoot.Module.EnemyPool
{
    public class EnemyPoolModel : BaseModel, IEnemyPoolModel
    {
        public bool IsPlaying { get; private set; } = false;
        public Vector2 Direction { get; private set; } = Vector2.right;
        public Vector3 SpawnPoint { get; private set; } = Vector3.zero;
        public Vector3 Position { get; private set; }
        public Vector3 DespawnPosition { get; private set; }
        public int PoolSize { get; private set; } = 20;
        public GameObject[] Pool = new GameObject[20];
        public float Gap { get; private set; } = 0.5f;
        public int KillCount { get; private set; } = 0;

        public void AddKill()
        {
            KillCount++;
            SetDataAsDirty();
        }

        public void ResetKill()
        {
            KillCount = 0;
            SetDataAsDirty();
        }
    }
}