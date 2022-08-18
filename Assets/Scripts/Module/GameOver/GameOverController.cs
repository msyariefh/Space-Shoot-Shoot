using Agate.MVC.Core;
using Agate.MVC.Base;
using UnityEngine;
using SpaceShootShoot.Persistent.SaveData;
using System.Collections;
using SpaceShootShoot.Module.Message;
using SpaceShootShoot.Boot;

namespace SpaceShootShoot.Module.GameOver
{
    public class GameOverController : ObjectController<GameOverController, GameOverModel, IGameOverModel, GameOverView>
    {
        private SaveDataController _saveDataCtrl;

        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
            _model.SetHighScore(_saveDataCtrl.Model.HighScore);
            _model.SetPlayerScore(0);
           
        }

        public override void SetView(GameOverView view)
        {
            base.SetView(view);
            _view.SetCallback(OnMainMenuClicked, OnRetryClicked);
        }

        public void GameOver(GameOverMessage message)
        {
            _model.SetPlayerScore(message.PlayerScore);
            _view.gameObject.SetActive(true);
        }

       

        public void OnMainMenuClicked()
        {
            GameOverConfirmed();
            SceneLoader.Instance.LoadScene("MainMenu");
            //back to menu
        }

        public void OnRetryClicked()
        {
            GameOverConfirmed();
            SceneLoader.Instance.LoadScene("Gameplay");
            //retry game
        }

        public void GameOverConfirmed()
        {
            Publish<GameOverConfirmedMessage>
                (new GameOverConfirmedMessage(_view.InputField.text, _model.PlayerScore));
        }
    }
}


