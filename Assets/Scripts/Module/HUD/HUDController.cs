using Agate.MVC.Base;
using SpaceShootShoot.Message;
using SpaceShootShoot.Module.Message;
using SpaceShootShoot.Persistent.SaveData;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace SpaceShootShoot.Module.HUD
{
    public class HUDController : ObjectController<HUDController, HUDView>
    {
        private SaveDataController _saveData;
        private int tick = 3;
        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
            
        }

        public override void SetView(HUDView view)
        {
            base.SetView(view);
            _view.HighScore.text = ConvertScore(_saveData.Model.HighScore);
        }
        public void UpdateScoreView(ScoreChangedMessage message)
        {
            _view.Score.text = ConvertScore(message.Score);
        }
        public void UpdateLifePoints(PlayerHitMessage message)
        {
            _view.LifePoints[tick - 1].color = new Color32(0, 0, 0, 255);
            tick--;
        }
        
        public void UpdatePowerUp(PowerUpStateMessage message)
        {
            Image _powerUp = _view.PowerUp.gameObject.GetComponent<Image>();
            switch (message.IsActive)
            {
                case true:
                    _powerUp.color =  new Color(255, 255, 255);
                    break;
                case false:
                    _powerUp.color = new Color(0, 0, 0);
                    break;
            }
        }

        private string ConvertScore(int score)
        {
            if (score >= 0 && score < 10) return "00000" + score.ToString();
            if (score >= 10 && score < 100) return "0000" + score.ToString();
            if (score >= 100 && score < 1000) return "000" + score.ToString();
            if (score >= 1000 && score < 10000) return "00" + score.ToString();
            if (score >= 10000 && score < 100000) return "0" + score.ToString();
            return score.ToString();
        }
    }
}

