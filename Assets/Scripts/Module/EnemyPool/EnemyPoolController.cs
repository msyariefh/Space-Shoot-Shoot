using System.Collections;
using Agate.MVC.Base;
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

        public void InitPoolObject()
        {
            for (int i = 0; i < _model.PoolSize; i++)
            {
                GameObject enemyPrefab = Resources.Load<GameObject>(@"Prefabs/Enemy");
                GameObject enemy = Object.Instantiate(enemyPrefab, _view.transform);
                SpawnEnemy(enemy, i);
                _model.Pool[i] = enemy;
            }
        }

        public void SpawnEnemy(GameObject enemy, int enemyNumber)
        {
            enemy.transform.localPosition = new Vector3((enemyNumber % 5) + (enemyNumber * _model.Gap % 5) - 4f, (enemyNumber / 5) + (enemyNumber / 5 * _model.Gap));
        }
    }
}