using System.Collections;
using UnityEngine;
using Agate.MVC.Base;

namespace SpaceShootShoot.Module.Player 
{
    public class PlayerView : ObjectView<IPlayerModel>
    {
        Vector2 direction;

        protected override void InitRenderModel(IPlayerModel model)
        {
            direction = Vector2.zero;
        }

        protected override void UpdateRenderModel(IPlayerModel model)
        {
            direction = model.Direction;
        }

        private void Update() 
        {
            transform.Translate(direction * Time.deltaTime * 10f);
        }
    }
}