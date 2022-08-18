using Agate.MVC.Base;
using SpaceShootShoot.Message;

namespace SpaceShootShoot.Module.Barrier
{
    public class BarrierConnector : BaseConnector
    {
        private BarrierController _barrier;

        protected override void Connect()
        {
            Subscribe<BarrierHitMessage>(_barrier.OnHit);
        }

        protected override void Disconnect()
        {
            Unsubscribe<BarrierHitMessage>(_barrier.OnHit);
        }
    }
}