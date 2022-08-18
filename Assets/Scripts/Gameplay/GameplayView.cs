using Agate.MVC.Base;
using UnityEngine;
using SpaceShootShoot.Module.Player;
using SpaceShootShoot.Persistent.AudioManager;
using SpaceShootShoot.Module.Bullet;
using SpaceShootShoot.Module.GameOver;
using SpaceShootShoot.Module.EnemyPool;
using SpaceShootShoot.Module.HUD;
using SpaceShootShoot.Module.EnemyBullet;
using SpaceShootShoot.Module.Barrier;
using SpaceShootShoot.Module.PowerUp;

namespace SpaceShootShoot.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField] public PlayerView PlayerView;
        [SerializeField] private AudioManagerView _audioManagerView;
        [SerializeField] private GameOverView _gameOverView;
        [SerializeField] private HUDView _hudView;
        [SerializeField] private PowerUpView _powerUpView;
        public AudioManagerView AudioManagerView => _audioManagerView;
        public GameOverView GameOverView => _gameOverView;
        public HUDView HUDView => _hudView;
        public PowerUpView PowerUpView => _powerUpView;

        [SerializeField] public BulletView BulletView;
        [SerializeField] public EnemyPoolView EnemyPoolView;
        [SerializeField] public EnemyBulletView EnemyBulletView;
        [SerializeField] public BarrierView BarrierView;
    }
}


