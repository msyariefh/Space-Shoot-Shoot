using Agate.MVC.Core;
using Agate.MVC.Base;
using UnityEngine;
using SpaceShootShoot.Module.Message;

namespace SpaceShootShoot.Module.GameOver
{
    public class GameOverConnector : BaseConnector
    {
        private GameOverController _gameOverCtrl;
        protected override void Connect()
        {
            Subscribe<GameOverMessage>(_gameOverCtrl.GameOver);
        }

        protected override void Disconnect()
        {
            Unsubscribe<GameOverMessage>(_gameOverCtrl.GameOver);
        }
    }
}

