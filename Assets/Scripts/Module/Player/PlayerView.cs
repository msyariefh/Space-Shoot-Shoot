using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;

namespace SpaceShootShoot.Module.Player
{
    public class PlayerView : ObjectView<IPlayerModel>
    {
        Vector2 direction;
        private UnityAction _onShoot;

        public void SetCallbacks(UnityAction onShoot)
        {
            _onShoot = onShoot;
        }

        protected override void InitRenderModel(IPlayerModel model)
        {
            direction = Vector2.zero;
        }

        protected override void UpdateRenderModel(IPlayerModel model)
        {   
            direction = model.Direction;
        }

        private void Start()
        {
            StartCoroutine(Shoot());
        }

        private void Update()
        {
            if (transform.position.x <= -10 && direction.x < 0)
            {
                return;
            }

            if (transform.position.x >= 10 && direction.x > 0)
            {
                return;
            }

            transform.Translate(direction * Time.deltaTime * 10f);
        }

        private IEnumerator Shoot()
        {
            yield return new WaitForSeconds(1);
            _onShoot?.Invoke();
            StartCoroutine(Shoot());
        }
    }
}