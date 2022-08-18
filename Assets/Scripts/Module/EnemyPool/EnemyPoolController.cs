using System.Collections;
using Agate.MVC.Base;
using SpaceShootShoot.Message;
using UnityEngine;

namespace SpaceShootShoot.Module.EnemyPool
{
    public class EnemyPoolController : ObjectController<EnemyPoolController, EnemyPoolModel, IEnemyPoolModel, EnemyPoolView>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
        }

        public override void SetView(EnemyPoolView view)
        {
            base.SetView(view);
            InitPoolObject();
        }

        private void InitPoolObject()
        {
            for (int i = 0; i < _model.PoolSize; i++)
            {
                GameObject enemyPrefab = Resources.Load<GameObject>(@"Prefabs/Enemy");
                GameObject enemy = Object.Instantiate(enemyPrefab, _view.transform);
                SpawnEnemy(enemy, i);
                _model.Pool[i] = enemy;
            }
        }

        private void SpawnEnemy(GameObject enemy, int enemyNumber)
        {
            enemy.transform.position = new Vector3((enemyNumber % 5) + (enemyNumber * _model.Gap % 5) - 4f, (enemyNumber / 5) + (enemyNumber / 5 * _model.Gap));
            enemy.SetActive(true);
        }

        private void ResetPoolObject()
        {
            _view.transform.position = Vector3.zero + Vector3.down;

            for (int i = 0; i < _model.PoolSize; i++)
            {
                SpawnEnemy(_model.Pool[i], i);
            }
        }

        public void OnEnemyHit(EnemyHitMessage message)
        {
            _model.AddKill();
            if (_model.KillCount == _model.PoolSize)
            {
                Debug.Log("Wave cleared");
                ResetPoolObject();
                _model.ResetKill();
            }
        }
    }
}