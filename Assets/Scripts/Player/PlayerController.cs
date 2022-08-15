using System.Collections;
using UnityEngine;
using Agate.MVC.Base;
using SpaceShootShoot.Message;

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
        }

        public void OnMovePlayer(MovePlayerMessage message)
        {
            _model.SetDirection(message.Direction);
        }
    }
}