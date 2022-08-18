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
        }

        public void OnShoot(PlayerShootMessage message)
        {
            Debug.Log(message.Position);
            _view.transform.position = message.Position;
        }
    }
}