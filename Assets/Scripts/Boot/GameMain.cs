using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SpaceShootShoot.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {
        protected override IConnector[] GetConnectors()
        {
            return null;
        }

        protected override IController[] GetDependencies()
        {
            return null;
        }

        protected override IEnumerator StartInit()
        {
            CreateEventSystem();
            CreateCamera();
            yield return null;
        }

        private void CreateEventSystem()
        {
            GameObject obj = new ("Event System");
            obj.AddComponent<EventSystem>();
            obj.AddComponent<StandaloneInputModule>();

            GameObject.DontDestroyOnLoad(obj);
        }

        private void CreateCamera()
        {
            GameObject obj = new ("Camera");
            obj.AddComponent<Camera>();
            obj.AddComponent<AudioListener>();

            GameObject.DontDestroyOnLoad(obj);
        }
    }
}
