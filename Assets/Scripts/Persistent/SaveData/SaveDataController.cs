using System.Collections;
using UnityEngine;
using Agate.MVC.Base;
using System.Linq;
using System;
using SpaceShootShoot.Module.Message;

namespace SpaceShootShoot.Persistent.SaveData
{
    public class SaveDataController : DataController<SaveDataController, SaveDataModel, ISaveDataModel>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            LoadInit();
        }

        public void SetLeaderboardData(GameOverConfirmedMessage message)
        {
            PlayerPrefs.SetString("LeaderNames", string.Join("/n", _model.LeaderNames));
            PlayerPrefs.SetString("LeaderScores", string.Join("/n", _model.LeaderScores));
            PlayerPrefs.Save();
        }
        private void LoadInit()
        {
            string[] leaderboardNames = PlayerPrefs.GetString("LeaderNames").Split("/n");
            int[] leaderboardScores = PlayerPrefs.GetString("LeaderScores")?.Split("/n")?.Select(Int32.Parse)?.ToArray();

            _model.SetLeaderboard(leaderboardNames, leaderboardScores);

        }
    }
}

