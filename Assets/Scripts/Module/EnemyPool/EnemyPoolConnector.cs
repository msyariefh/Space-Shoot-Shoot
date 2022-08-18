using Agate.MVC.Base;
using SpaceShootShoot.Message;
using SpaceShootShoot.Module.Message;

namespace SpaceShootShoot.Module.EnemyPool
{
    public class EnemyPoolConnector : BaseConnector
    {
        private EnemyPoolController _enemyPool;
        
        protected override void Connect()
        {
            Subscribe<EnemyHitMessage>(_enemyPool.OnEnemyHit);
            Subscribe<GameOverMessage>(_enemyPool.GameOver);
        }

        protected override void Disconnect()
        {
            Unsubscribe<EnemyHitMessage>(_enemyPool.OnEnemyHit);
            Unsubscribe<GameOverMessage>(_enemyPool.GameOver);
        }
    }
}