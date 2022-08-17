using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceShootShoot.Boot;
using SpaceShootShoot.Persistent.AudioManager;
using System.Collections;
using UnityEngine;

namespace SpaceShootShoot.MainMenu
{
    public class MainMenuLauncher : SceneLauncher<MainMenuLauncher, MainMenuView>
    {
        public override string SceneName => "MainMenu";

        private AudioManagerController _audioCtrl; 
        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return null;
        }

        protected override IEnumerator InitSceneObject()
        {
            _audioCtrl.SetView(_view.AudioManagerView);
            _view.SetCallbacks(OnClickPlayButton);
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
    }
}


