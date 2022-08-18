using System.Collections;
using UnityEngine;
using Agate.MVC.Base;
using SpaceShootShoot.Message;

namespace SpaceShootShoot.Module.EnemyBullet 
{
    public class EnemyBulletController : ObjectController<EnemyBulletController, EnemyBulletModel, IEnemyBulletModel, EnemyBulletView> 
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
        }

        public override void SetView(EnemyBulletView view)
        {
            base.SetView(view);
            _model.SetSpeed(_view.GetSpeed());
            view.SetCallbacks(OnPlayerHit, OnBarrierHit);
        }

        public void OnShoot(EnemyShootMessage message)
        {
            _view.transform.position = message.Position;
            _view.gameObject.SetActive(true);
        }

        private void OnPlayerHit(GameObject player)
        {
            _view.gameObject.SetActive(false);
            Publish<PlayerHitMessage>(new PlayerHitMessage());
        }

        private void OnBarrierHit(GameObject barrier)
        {
            _view.gameObject.SetActive(false);
            Publish<BarrierHitMessage>(new BarrierHitMessage(barrier.name));
        }
    }
}