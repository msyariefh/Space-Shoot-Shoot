using System.Collections;
using UnityEngine.InputSystem;
using UnityEngine;
using Agate.MVC.Base;
using SpaceShootShoot.Message;

namespace SpaceShootShoot.Module.UserInput
{
    public class UserInputController : BaseController<UserInputController>
    {
        private InputActionManager _inputActionManager = new InputActionManager();

        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            _inputActionManager.Player.Enable();
            _inputActionManager.Player.Movement.performed += OnMoveInput;
            _inputActionManager.Player.Movement.canceled += OnMoveInput;
        }

        private void OnMoveInput(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                Publish<MovePlayerMessage>(new MovePlayerMessage((Vector2)context.ReadValueAsObject()));
            }
            
            if (context.canceled)
            {
                Publish<MovePlayerMessage>(new MovePlayerMessage(Vector2.zero));
            }
        }
    }
}