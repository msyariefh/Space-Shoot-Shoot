using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace SpaceShootShoot.Module.HUD
{
    public class HUDView : BaseView
    {
        [SerializeField] private TMP_Text _highScore;
        [SerializeField] private TMP_Text _score;
        [SerializeField] private Image _powerUp;
        [SerializeField] private Image[] _lifePoints;

        public TMP_Text HighScore => _highScore;
        public TMP_Text Score => _score;
        public Image PowerUp => _powerUp;
        public Image[] LifePoints => _lifePoints;
    }
}


