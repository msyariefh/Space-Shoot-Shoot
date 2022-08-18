using Agate.MVC.Core;
using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

namespace SpaceShootShoot.Module.GameOver
{
    public class GameOverView : ObjectView<IGameOverModel>
    {
        [SerializeField] private TMP_InputField _inputField;
        [SerializeField] private Button _retryButton;
        [SerializeField] private Button _mainMenuButton;

        public TMP_InputField InputField => _inputField;
        public Button RetryButton => _retryButton;
        public Button MainMenuButton => _mainMenuButton;

        public void SetCallback(UnityAction onMainMenuClicked, UnityAction onRetryClicked)
        {
            _mainMenuButton.onClick.RemoveAllListeners();
            _retryButton.onClick.RemoveAllListeners();
            _mainMenuButton.onClick.AddListener(onMainMenuClicked);
            _retryButton.onClick.AddListener(onRetryClicked);
        }


        protected override void InitRenderModel(IGameOverModel model)
        {
            
        }

        protected override void UpdateRenderModel(IGameOverModel model)
        {
            
        }
    }
}


