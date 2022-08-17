using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceShootShoot.Boot;
using System.Collections;
using UnityEngine;
using SpaceShootShoot.Module.Player;
using SpaceShootShoot.Module.UserInput;
using SpaceShootShoot.Persistent.AudioManager;

namespace SpaceShootShoot.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        public override string SceneName => "Gameplay";

        private PlayerController _player;
        private AudioManagerController _audioCtrl;

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[] {
                new PlayerConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[] {
                new PlayerController(),
                new UserInputController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _player.SetView(_view.PlayerView);
            _audioCtrl.SetView(_view.AudioManagerView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}

