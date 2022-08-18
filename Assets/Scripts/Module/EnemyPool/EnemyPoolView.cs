using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;

namespace SpaceShootShoot.Module.EnemyPool
{
    public class EnemyPoolView : ObjectView<IEnemyPoolModel>
    {
        Vector2 direction;

        public void SetCallbacks(UnityAction onShoot)
        {

        }

        protected override void InitRenderModel(IEnemyPoolModel model)
        {
            direction = model.Direction;
        }

        protected override void UpdateRenderModel(IEnemyPoolModel model)
        {
            direction = model.Direction;
        }

        private void Update()
        {
            if (transform.position.x >= 6 || transform.position.x <= -6)
            {
                direction *= -1;
            }
            transform.Translate(direction * Time.deltaTime * 5f);
        }
    }
}