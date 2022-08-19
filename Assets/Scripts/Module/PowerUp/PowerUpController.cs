using Agate.MVC.Base;
using SpaceShootShoot.Message;
using UnityEngine;
using Unity;
using System.Collections;

namespace SpaceShootShoot.Module.PowerUp
{
    public class PowerUpController : ObjectController<PowerUpController, PowerUpView>
    {
        
        public void OnPowerUp(PowerUpMessage message)
        {
            Publish<PowerUpStateMessage>(new PowerUpStateMessage(true));
            EffectTimer(_view.EffectDuration);
            
            _view.gameObject.SetActive(false);
        }

        public override void SetView(PowerUpView view)
        {
            base.SetView(view);
            InitObject();
        }
        private async void EffectTimer (float time)
        {
            await System.Threading.Tasks.Task.Delay(Mathf.FloorToInt(time * 1000));
            Publish<PowerUpStateMessage>(new PowerUpStateMessage(false));
            InitObject();
        }

        

        private void InitObject()
        {
            float x = Random.Range(-7f, 7f);
            float y = Random.Range(-2.5f, 2.5f);

            _view.transform.position = new Vector3(x, y, 0);
            _view.gameObject.SetActive(true);
        }
    }
}


