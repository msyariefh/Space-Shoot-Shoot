using System.Collections;
using UnityEngine;
using Agate.MVC.Base;
using SpaceShootShoot.Message;
using SpaceShootShoot.Module.Message;

namespace SpaceShootShoot.Module.Player 
{
    public class PlayerController : ObjectController<PlayerController, PlayerModel, IPlayerModel, PlayerView> 
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
        }

        public override void SetView(PlayerView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnShoot);
        }

        public void OnMovePlayer(MovePlayerMessage message)
        {
            _model.SetDirection(message.Direction);
        }

        private void OnShoot()
        {
            Publish<PlayerShootMessage>(new PlayerShootMessage(_view.transform.position));
        }

        public void OnPlayerHit(PlayerHitMessage message)
        {
            Debug.Log("hit");
            _model.DecreaseHealth();
            if (_model.Health <= 0)
            {
                Publish<GameOverMessage>(new GameOverMessage());
                _view.gameObject.SetActive(false);
            }
        }
    }
}