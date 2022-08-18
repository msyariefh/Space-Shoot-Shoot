using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;

namespace SpaceShootShoot.Module.Enemy
{
    public class EnemyView : ObjectView<IEnemyModel>
    {
        Vector2 direction;
        private UnityAction _onShoot;

        public void SetCallbacks(UnityAction onShoot)
        {
            _onShoot = onShoot;
        }

        protected override void InitRenderModel(IEnemyModel model)
        {
            direction = model.Direction;
        }

        protected override void UpdateRenderModel(IEnemyModel model)
        {
            direction = model.Direction;
        }

        private void Start()
        {
            StartCoroutine(Shoot());
        }

        private void Update()
        {
            if (transform.position.x >= 10 || transform.position.x <= -10)
            {
                direction *= -1;
            }
            transform.Translate(direction * Time.deltaTime * 5f);
        }

        private IEnumerator Shoot()
        {
            yield return new WaitForSeconds(1);
            _onShoot?.Invoke();
            StartCoroutine(Shoot());
        }
    }
}