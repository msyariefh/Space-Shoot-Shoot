using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceShootShoot.Persistent.SaveData;
using System.Collections;
using UnityEngine;


namespace SpaceShootShoot.Module.Leaderboard
{
    public class LeaderboardController : ObjectController<LeaderboardController, LeaderboardModel, ILeaderboardModel, LeaderboardView>
    {
        private SaveDataController _saveData;

        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
            _model.SetNames(_saveData.Model.LeaderNames);
            _model.SetScores(_saveData.Model.LeaderScores);

        }
        private void OnBackButtonClicked()
        {
            _view.gameObject.SetActive(false);
        }

        public override void SetView(LeaderboardView view)
        {
            base.SetView(view);
            view.SetCallback(OnBackButtonClicked);
        }
    }
}

