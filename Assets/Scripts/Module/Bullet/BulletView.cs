using System.Collections;
using UnityEngine;
using Agate.MVC.Base;
using UnityEngine.Events;

namespace SpaceShootShoot.Module.Bullet
{
    public class BulletView : ObjectView<IBulletModel>
    {
        Vector2 direction;
        [SerializeField] private float _speed;
        private UnityAction<GameObject> _onEnemyHit;

        public void SetCallbacks(UnityAction<GameObject> onEnemyHit)
        {
            _onEnemyHit = onEnemyHit;
        }

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

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Enemy")
            {
                _onEnemyHit?.Invoke(other.gameObject);
            }
        }
    }
}