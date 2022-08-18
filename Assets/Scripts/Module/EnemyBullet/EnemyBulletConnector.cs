using Agate.MVC.Base;
using SpaceShootShoot.Message;

namespace SpaceShootShoot.Module.EnemyBullet
{
    public class EnemyBulletConnector : BaseConnector
    {
        private EnemyBulletController _enemyBullet;

        protected override void Connect()
        {
            Subscribe<EnemyShootMessage>(_enemyBullet.OnShoot);
        }

        protected override void Disconnect()
        {
            Unsubscribe<EnemyShootMessage>(_enemyBullet.OnShoot);
        }
    }
}