using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceShootShoot.Boot;
using System.Collections;
using UnityEngine;
using SpaceShootShoot.Module.Player;
using SpaceShootShoot.Module.UserInput;
using SpaceShootShoot.Persistent.AudioManager;
using SpaceShootShoot.Module.Bullet;
using SpaceShootShoot.Module.GameOver;

namespace SpaceShootShoot.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        public override string SceneName => "Gameplay";

        private PlayerController _player;
        private AudioManagerController _audioCtrl;
        private BulletController _bullet;
        private GameOverController _gameOver;

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[] {
                new PlayerConnector(),
                new BulletConnector(),
                new GameOverConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[] {
                new BulletController(),
                new PlayerController(),
                new UserInputController(),
                new BulletController(),
                new GameOverController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _player.SetView(_view.PlayerView);
            _audioCtrl.SetView(_view.AudioManagerView);
            _bullet.SetView(_view.BulletView);
            _gameOver.SetView(_view.GameOverView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}

