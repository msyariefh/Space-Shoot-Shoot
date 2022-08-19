using Agate.MVC.Base;
using SpaceShootShoot.Message;
using SpaceShootShoot.Module.Message;
using UnityEngine;

namespace SpaceShootShoot.Module.ScoreSystem
{
    public class ScoreSystemConnector : BaseConnector
    {
        private ScoreSystemController _scoreSystemCtrl;
        protected override void Connect()
        {
            Subscribe<EnemyHitMessage>(_scoreSystemCtrl.OnEnemyDamaged);
            Subscribe<GameOverMessage>(_scoreSystemCtrl.OnGameOver);
        }

        protected override void Disconnect()
        {
            Unsubscribe<EnemyHitMessage>(_scoreSystemCtrl.OnEnemyDamaged);
            Unsubscribe<GameOverMessage>(_scoreSystemCtrl.OnGameOver);
        }
    }
}

