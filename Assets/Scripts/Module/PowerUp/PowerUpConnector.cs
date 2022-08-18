using Agate.MVC.Base;
using UnityEngine;
using SpaceShootShoot.Message;

namespace SpaceShootShoot.Module.PowerUp
{
    public class PowerUpConnector : BaseConnector
    {
        private PowerUpController _powerUpCtrl;
        protected override void Connect()
        {
            Subscribe<PowerUpMessage>(_powerUpCtrl.OnPowerUp);
        }

        protected override void Disconnect()
        {
            Unsubscribe<PowerUpMessage>(_powerUpCtrl.OnPowerUp);
        }
    }
}

