using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

namespace SpaceShootShoot.Module.Leaderboard
{
    [System.Serializable]
    public class HighScore
    {
        [SerializeField] private TMP_Text _nameField;
        [SerializeField] private TMP_Text _scoreField;

        public TMP_Text NameField => _nameField;
        public TMP_Text ScoreField => _scoreField;

    }
    public class LeaderboardView : ObjectView<ILeaderboardModel>
    {
        [SerializeField] private HighScore[] _highScore;


        //[SerializeField] private TMP_Text 
        [SerializeField] private Button _backLeaderboardButton;
        public Button BackLeaderBoardButton => _backLeaderboardButton;

        public void SetCallback(UnityAction onBackButtonclicked)
        {
            _backLeaderboardButton.onClick.RemoveAllListeners();
            _backLeaderboardButton.onClick.AddListener(onBackButtonclicked);
        }

        protected override void InitRenderModel(ILeaderboardModel model)
        {
            print(model.Names);
            for(int i = 0; i< model.Names.Length; i++)
            {
                _highScore[i].NameField.text = model.Names[i].ToUpper();
                _highScore[i].ScoreField.text = model.Scores[i].ToString();
            }
        }

        protected override void UpdateRenderModel(ILeaderboardModel model)
        {

        }
    }
}

