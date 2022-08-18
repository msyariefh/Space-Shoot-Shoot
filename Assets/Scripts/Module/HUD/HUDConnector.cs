using Agate.MVC.Base;
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
        }

        protected override void Disconnect()
        {
            Unsubscribe<ScoreChangedMessage>(_hudCtrl.UpdateScoreView);
        }
    }
}

