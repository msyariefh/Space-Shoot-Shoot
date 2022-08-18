using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using UnityEngine;
using SpaceShootShoot.Module.Player;
using SpaceShootShoot.Persistent.AudioManager;
using SpaceShootShoot.Module.Bullet;

namespace SpaceShootShoot.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField] public PlayerView PlayerView;
        [SerializeField] private AudioManagerView _audioManagerView;
        public AudioManagerView AudioManagerView => _audioManagerView;
        [SerializeField] public BulletView BulletView;
    }
}


