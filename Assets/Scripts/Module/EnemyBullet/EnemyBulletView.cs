using System.Collections;
using UnityEngine;
using Agate.MVC.Base;
using UnityEngine.Events;

namespace SpaceShootShoot.Module.EnemyBullet
{
    public class EnemyBulletView : ObjectView<IEnemyBulletModel>
    {
        Vector2 direction;
        [SerializeField] private float _speed;
        private UnityAction<GameObject> _onPlayerHit;
        private UnityAction<GameObject> _onBarrierHit;

        public void SetCallbacks(UnityAction<GameObject> onPlayerHit, UnityAction<GameObject> onBarrierHit)
        {
            _onPlayerHit = onPlayerHit;
            _onBarrierHit = onBarrierHit;
        }

        protected override void InitRenderModel(IEnemyBulletModel model)
        {
            direction = Vector2.down;
        }

        protected override void UpdateRenderModel(IEnemyBulletModel model)
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
            if (other.tag == "Player")
            {
                _onPlayerHit?.Invoke(other.gameObject);
            }

            if(other.tag == "Barrier")
            {
                _onBarrierHit?.Invoke(other.gameObject);
            }
        }
    }
}