using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShootShoot.Module.PowerUp
{
    public class PowerUpView : BaseView
    {
        [SerializeField] private float _effectDuration;

        public float EffectDuration => _effectDuration;
    }
}

