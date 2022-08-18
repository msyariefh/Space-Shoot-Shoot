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
            Subscribe<TotalScoreMessage>(_gameOver.GameOver);
        }


        protected override void Disconnect()
        {
            Unsubscribe<TotalScoreMessage>(_gameOver.GameOver);
        }
    }
}

