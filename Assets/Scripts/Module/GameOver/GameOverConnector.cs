using Agate.MVC.Core;
using Agate.MVC.Base;
using UnityEngine;
using SpaceShootShoot.Module.Message;

namespace SpaceShootShoot.Module.GameOver
{
    public class GameOverConnector : BaseConnector
    {
        GameOverController _gameOver;

        protected override void Connect()
        {
            Subscribe<GameOverMessage>(_gameOver.GameOver);
        }

        protected override void Disconnect()
        {
            Unsubscribe<GameOverMessage>(_gameOver.GameOver);
        }
    }
}

