using System.Collections;
using Agate.MVC.Base;
using SpaceShootShoot.Message;
using SpaceShootShoot.Module.Message;
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
            view.SetCallbacks(OnShoot);
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
            enemy.transform.position = new Vector3((enemyNumber % 5) + (enemyNumber % 5 * _model.Gap) - 3, (enemyNumber / 5) + (enemyNumber / 5 * _model.Gap));
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

        private void OnShoot()
        {
            int column = Random.Range(0, 5);
            for (int i = column; i < 20; i += 5)
            {
                if (_model.Pool[i].activeInHierarchy)
                {
                    Publish<EnemyShootMessage>(new EnemyShootMessage(_model.Pool[i].transform.position));
                    break;
                }
            }
        }

        public void GameOver(GameOverMessage message)
        {
            _view.gameObject.SetActive(false);
        }
    }
}