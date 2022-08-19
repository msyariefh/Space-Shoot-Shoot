using System.Collections;
using UnityEngine;
using Agate.MVC.Base;
using SpaceShootShoot.Message;

namespace SpaceShootShoot.Module.Bullet 
{
    public class BulletController : ObjectController<BulletController, BulletModel, IBulletModel, BulletView> 
    {
        private bool isPowerUp = false;
        private int enhance = 0;
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
        }

        public override void SetView(BulletView view)
        {
            base.SetView(view);
            _model.SetSpeed(_view.GetSpeed());
            view.SetCallbacks(OnEnemyHit, OnPowerUpHit);
        }

        public void OnShoot(PlayerShootMessage message)
        {
            _view.transform.position = message.Position;
            _view.gameObject.SetActive(true);
        }

        public void PowerUp(PowerUpStateMessage message)
        {
            switch (message.IsActive)
            {
                case true:
                    isPowerUp = true;
                    enhance = 2;
                    break;
                case false:
                    isPowerUp = false;
                    break;
            }
        }
        private void OnEnemyHit(GameObject enemy)
        {
            if (isPowerUp)
            {
                if (enhance > 0) enhance--;
                else if (enhance == 0)
                {
                    _view.gameObject.SetActive(false);
                    enhance = 2;
                }
            }
            else
            {
                _view.gameObject.SetActive(false);
            }
            enemy.SetActive(false);
            Publish<EnemyHitMessage>(new EnemyHitMessage(10));
        }

        private void OnPowerUpHit()
        {
            _view.gameObject.SetActive(false);
            Publish<PowerUpMessage>(new PowerUpMessage());
        }
    }
}