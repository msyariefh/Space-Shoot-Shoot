using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using UnityEngine;
using SpaceShootShoot.Module.Player;
using SpaceShootShoot.Persistent.AudioManager;
using SpaceShootShoot.Module.Bullet;
using SpaceShootShoot.Module.GameOver;
using SpaceShootShoot.Module.EnemyPool;
using SpaceShootShoot.Module.EnemyBullet;
using SpaceShootShoot.Module.Barrier;

namespace SpaceShootShoot.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField] public PlayerView PlayerView;
        [SerializeField] private AudioManagerView _audioManagerView;
        [SerializeField] private GameOverView _gameOverView;
        public AudioManagerView AudioManagerView => _audioManagerView;
        public GameOverView GameOverView => _gameOverView;
        [SerializeField] public BulletView BulletView;
        [SerializeField] public EnemyPoolView EnemyPoolView;
        [SerializeField] public EnemyBulletView EnemyBulletView;
        [SerializeField] public BarrierView BarrierView;
    }
}


