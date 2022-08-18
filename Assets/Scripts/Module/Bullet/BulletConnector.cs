using Agate.MVC.Base;
using SpaceShootShoot.Message;

namespace SpaceShootShoot.Module.Bullet
{
    public class BulletConnector : BaseConnector
    {
        private BulletController _bullet;

        protected override void Connect()
        {
            Subscribe<PlayerShootMessage>(_bullet.OnShoot);
            Subscribe<PowerUpStateMessage>(_bullet.PowerUp);
        }

        protected override void Disconnect()
        {
            Unsubscribe<PlayerShootMessage>(_bullet.OnShoot);
            Unsubscribe<PowerUpStateMessage>(_bullet.PowerUp);
        }
    }
}