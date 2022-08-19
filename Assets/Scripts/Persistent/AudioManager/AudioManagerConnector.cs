using Agate.MVC.Base;
using SpaceShootShoot.Message;
using SpaceShootShoot.Module.Message;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpaceShootShoot.Persistent.AudioManager
{
    public class AudioManagerConnector : BaseConnector
    {
        private AudioManagerController _audioCtrl;
        protected override void Connect()
        {
            Subscribe<PlayerShootMessage>(_audioCtrl.OnPlayerShoot);
            Subscribe<ButtonPressedMessage>(_audioCtrl.OnButtonPressed);
            Subscribe<EnemyHitMessage>(_audioCtrl.OnEnemyDestroyed);
            Subscribe<PlayerHitMessage>(_audioCtrl.OnPlayerHit);
            Subscribe<EnemyShootMessage>(_audioCtrl.OnEnemyShoot);
        }

        protected override void Disconnect()
        {
            Unsubscribe<PlayerShootMessage>(_audioCtrl.OnPlayerShoot);
            Unsubscribe<ButtonPressedMessage>(_audioCtrl.OnButtonPressed);
            Unsubscribe<EnemyHitMessage>(_audioCtrl.OnEnemyDestroyed);
            Unsubscribe<PlayerHitMessage>(_audioCtrl.OnPlayerHit);
            Unsubscribe<EnemyShootMessage>(_audioCtrl.OnEnemyShoot);
        }
    }
}

