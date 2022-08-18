using System.Collections;
using UnityEngine;
using Agate.MVC.Base;
using SpaceShootShoot.Message;

namespace SpaceShootShoot.Module.Bullet 
{
    public class BulletController : ObjectController<BulletController, BulletModel, IBulletModel, BulletView> 
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
        }

        public override void SetView(BulletView view)
        {
            base.SetView(view);
            _model.SetSpeed(_view.GetSpeed());
            view.SetCallbacks(OnEnemyHit);
        }

        public void OnShoot(PlayerShootMessage message)
        {
            _view.transform.position = message.Position;
            _view.gameObject.SetActive(true);
        }

        private void OnEnemyHit(GameObject enemy)
        {
            _view.gameObject.SetActive(false);
            enemy.SetActive(false);
            Publish<EnemyHitMessage>(new EnemyHitMessage());
        }
    }
}