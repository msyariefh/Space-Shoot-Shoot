using Agate.MVC.Base;
using SpaceShootShoot.Message;
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
        }

        protected override void Disconnect()
        {
            Unsubscribe<PlayerShootMessage>(_audioCtrl.OnPlayerShoot);
        }
    }
}

