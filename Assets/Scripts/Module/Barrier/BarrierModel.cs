using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShootShoot.Module.Barrier
{
    public class BarrierModel : BaseModel, IBarrierModel
    {
        public int[] Health { get; private set; } = new int[4];
        public int PoolSize { get; private set; } = 4;
        public GameObject[] Pool { get; private set; } = new GameObject[4];
        public float Gap { get; private set; } = 5f;

        public void DecreaseHealth(int number)
        {
            Health[number]--;
            SetDataAsDirty();
        }

        public void ResetHealth()
        {
            for (int i = 0; i < Health.Length; i++)
            {
                Health[i] = 3;
            }
            SetDataAsDirty();
        }
    }
}