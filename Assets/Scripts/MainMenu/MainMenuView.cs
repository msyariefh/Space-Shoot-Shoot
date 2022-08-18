using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceShootShoot.Boot;
using SpaceShootShoot.Persistent.AudioManager;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using SpaceShootShoot.Module.Leaderboard;

namespace SpaceShootShoot.MainMenu
{
    public class MainMenuView : BaseSceneView
    {
        public void SetCallbacks(UnityAction onClickPlayButton, UnityAction onLeaderboardClicked)
        {
            _playButton.onClick.RemoveAllListeners();
            _playButton.onClick.AddListener(onClickPlayButton);
            _leaderboardButton.onClick.RemoveAllListeners();
            _leaderboardButton.onClick.AddListener(onLeaderboardClicked);
        }

        [SerializeField] private AudioManagerView audioManagerView;
        [SerializeField] private LeaderboardView leaderboardView;
        [SerializeField] private Button _playButton;
        [SerializeField] private Button _leaderboardButton;
        
        public AudioManagerView AudioManagerView => audioManagerView;
        public LeaderboardView LeaderboardView => leaderboardView;
        public Button PlayButton => _playButton;
        public Button LeaderboardButton => _leaderboardButton;
        


    }
    
}

