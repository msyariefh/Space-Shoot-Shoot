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
            AddPlayerPrefs();
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
            string leaderNames = PlayerPrefs.GetString("LeaderNames");
            string leaderScores = PlayerPrefs.GetString("LeaderScores");
            //Debug.Log($"{leaderNames.Length} \n{leaderScores.Length}");
            if (leaderNames.Length <= 0 && leaderScores.Length <= 0)
            {
                _model.SetLeaderboard(new string[0], new int[0]);
                return;
            }

            string[] leaderboardNames = PlayerPrefs.GetString("LeaderNames")?.Split("/n");
            int[] leaderboardScores = PlayerPrefs.GetString("LeaderScores")?.Split("/n")?.Select(Int32.Parse)?.ToArray();

            _model.SetLeaderboard(leaderboardNames, leaderboardScores);

        }

        //test
        private void AddPlayerPrefs()
        {
            string[] nama = { "Aceng", "Doni", "Farid" };
            int[] scores = { 120, 1200, 199 };
            PlayerPrefs.SetString("LeaderNames", string.Join("/n", nama));
            PlayerPrefs.SetString("LeaderScores", string.Join("/n", scores));
            PlayerPrefs.Save();
        }
    }
}

