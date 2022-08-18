using Agate.MVC.Base;
using SpaceShootShoot.Message;
using SpaceShootShoot.Module.Message;
using System.Collections;
using UnityEngine;

namespace SpaceShootShoot.Module.ScoreSystem
{
    public class ScoreSystemController : DataController<ScoreSystemController, ScoreSystemModel, IScoreSystemModel> 
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            _model.SetPlayerScore(0);
        }

        public void OnEnemyDamaged(EnemyHitMessage message)
        {
            _model.SetPlayerScore(_model.PlayerScore + message.ScoreDropped);
            Publish<ScoreChangedMessage>(new ScoreChangedMessage(_model.PlayerScore));
        }

        public void OnGameOver(GameOverMessage message)
        {
            Publish<TotalScoreMessage>(new TotalScoreMessage(_model.PlayerScore));
        }
    }
}

