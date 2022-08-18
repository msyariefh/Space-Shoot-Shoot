using System.Collections;
using UnityEngine;
using Agate.MVC.Base;
using SpaceShootShoot.Message;

namespace SpaceShootShoot.Module.Enemy 
{
    public class EnemyController : ObjectController<EnemyController, EnemyModel, IEnemyModel, EnemyView> 
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
        }

        public override void SetView(EnemyView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnShoot);
        }

        public void OnShoot()
        {
            Publish<EnemyShootMessage>(new EnemyShootMessage(_view.transform.position));
        }
    }
}