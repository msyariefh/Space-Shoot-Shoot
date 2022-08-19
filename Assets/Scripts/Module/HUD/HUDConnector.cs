using Agate.MVC.Base;
using SpaceShootShoot.Message;
using SpaceShootShoot.Module.Message;
using UnityEngine;

namespace SpaceShootShoot.Module.HUD
{
    public class HUDConnector : BaseConnector
    {
        private HUDController _hudCtrl;
        protected override void Connect()
        {
            Subscribe<ScoreChangedMessage>(_hudCtrl.UpdateScoreView);
            Subscribe<PlayerHitMessage>(_hudCtrl.UpdateLifePoints);
            Subscribe<PowerUpStateMessage>(_hudCtrl.UpdatePowerUp);
        }

        protected override void Disconnect()
        {
            Unsubscribe<ScoreChangedMessage>(_hudCtrl.UpdateScoreView);
            Unsubscribe<PlayerHitMessage>(_hudCtrl.UpdateLifePoints);
            Unsubscribe<PowerUpStateMessage>(_hudCtrl.UpdatePowerUp);
        }
    }
}

