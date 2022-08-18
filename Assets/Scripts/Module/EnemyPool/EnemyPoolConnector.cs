using Agate.MVC.Base;
using SpaceShootShoot.Message;

namespace SpaceShootShoot.Module.EnemyPool
{
    public class EnemyPoolConnector : BaseConnector
    {
        private EnemyPoolController _enemyPool;
        
        protected override void Connect()
        {
            Subscribe<EnemyHitMessage>(_enemyPool.OnEnemyHit);
        }

        protected override void Disconnect()
        {
            Unsubscribe<EnemyHitMessage>(_enemyPool.OnEnemyHit);
        }
    }
}