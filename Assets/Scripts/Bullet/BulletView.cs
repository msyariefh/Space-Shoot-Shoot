using System.Collections;
using UnityEngine;
using Agate.MVC.Base;

namespace SpaceShootShoot.Module.Bullet
{
    public class BulletView : ObjectView<IBulletModel>
    {
        Vector2 direction;
        [SerializeField] private float _speed;

        protected override void InitRenderModel(IBulletModel model)
        {
            direction = Vector2.up;
        }

        protected override void UpdateRenderModel(IBulletModel model)
        {
            
        }

        private void Update()
        {
            transform.Translate(direction * _speed * Time.deltaTime);
        }

        public float GetSpeed()
        {
            return _speed;
        }
    }
}