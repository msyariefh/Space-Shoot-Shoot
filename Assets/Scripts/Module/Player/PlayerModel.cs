using Agate.MVC.Base;
using UnityEngine;

namespace SpaceShootShoot.Module.Player
{
    public class PlayerModel : BaseModel, IPlayerModel
    {
        public string Name { get; private set; }
        public float Speed { get; }
        public Vector2 Direction {get; private set; }

        public void SetName(string name)
        {
            Name = name;
            SetDataAsDirty();
        }

        public void SetDirection(Vector2 direction)
        {
            Direction = direction;
            SetDataAsDirty();
        }
    }
}