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
            
        }

        private void Update()
        {
            float temp = transform.position.x + direction.x;

            if (temp >= 7 || temp <= -7)
            {
                direction *= -1;
                transform.Translate(Vector3.down * 0.1f);
            }

            transform.Translate(direction * Time.deltaTime * 5f);
        }
    }
}