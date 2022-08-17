using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceShootShoot.Boot;
using SpaceShootShoot.Persistent.AudioManager;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceShootShoot.MainMenu
{
    public class MainMenuView : BaseSceneView
    {
        public void SetCallbacks(UnityAction onClickPlayButton)
        {
        }

        [SerializeField] private AudioManagerView audioManagerView;
        public AudioManagerView AudioManagerView => audioManagerView;
    }
    
}

