using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using UnityEngine;
using SpaceShootShoot.Module.Player;
using SpaceShootShoot.Module.Bullet;

namespace SpaceShootShoot.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField] public PlayerView PlayerView;
        [SerializeField] public BulletView BulletView;
    }
}


