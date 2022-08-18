using System.Collections;
using UnityEngine;
using Agate.MVC.Base;
using SpaceShootShoot.Message;

namespace SpaceShootShoot.Module.Barrier
{
    public class BarrierController : ObjectController<BarrierController, BarrierModel, IBarrierModel, BarrierView>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
        }

        public override void SetView(BarrierView view)
        {
            base.SetView(view);
            InitPoolObject();
            _model.ResetHealth();
        }

        private void InitPoolObject()
        {
            Debug.Log("init barrier");
            for (int i = 0; i < _model.PoolSize; i++)
            {
                GameObject barrierPrefab = Resources.Load<GameObject>(@"Prefabs/Barrier");
                GameObject barrier = Object.Instantiate(barrierPrefab, _view.transform);
                barrier.name = "Barrier " + (i + 1);
                SpawnBarrier(barrier, i);
                _model.Pool[i] = barrier;
            }
        }

        private void SpawnBarrier(GameObject barrier, int barrierNumber)
        {
            barrier.transform.position = new Vector3((barrierNumber) + (barrierNumber * _model.Gap) - (_model.Gap + 2 + (_model.Gap - 1) * 0.5f), _view.transform.position.y, 0);
        }

        public void OnHit(BarrierHitMessage message)
        {
            int barrierNumber = int.Parse(message.Name.Split()[1]) - 1;
            _model.DecreaseHealth(barrierNumber);
            if (_model.Health[barrierNumber] <= 0)
            {
                _model.Pool[barrierNumber].SetActive(false);
            }
        }
    }
}