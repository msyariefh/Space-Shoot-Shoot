using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceShootShoot.Boot;
using SpaceShootShoot.Module.Leaderboard;
using SpaceShootShoot.Persistent.AudioManager;
using System.Collections;
using UnityEngine;

namespace SpaceShootShoot.MainMenu
{
    public class MainMenuLauncher : SceneLauncher<MainMenuLauncher, MainMenuView>
    {
        public override string SceneName => "MainMenu";

        private AudioManagerController _audioCtrl;
        private LeaderboardController _leaderboardCtrl;
        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {

            return new IController[] {
                new LeaderboardController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _audioCtrl.SetView(_view.AudioManagerView);
            _leaderboardCtrl.SetView(_view.LeaderboardView);
            _view.SetCallbacks(OnClickPlayButton, OnLeaderboardClicked);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

        private void OnClickPlayButton()
        {
            SceneLoader.Instance.LoadScene("Gameplay");
        }
        private void OnLeaderboardClicked()
        {
            _view.LeaderboardView.gameObject.SetActive(true);
        }
    }
}


