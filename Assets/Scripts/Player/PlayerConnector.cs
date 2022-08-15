using Agate.MVC.Base;
using SpaceShootShoot.Message;

namespace SpaceShootShoot.Module.Player
{
    public class PlayerConnector : BaseConnector
    {
        private PlayerController _player;
        protected override void Connect()
        {
            Subscribe<MovePlayerMessage>(_player.OnMovePlayer);
        }

        protected override void Disconnect()
        {
            Unsubscribe<MovePlayerMessage>(_player.OnMovePlayer);
        }
    }
}