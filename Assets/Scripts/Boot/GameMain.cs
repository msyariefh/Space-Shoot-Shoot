using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.UI;
using SpaceShootShoot.Persistent.AudioManager;
using SpaceShootShoot.Persistent.SaveData;

namespace SpaceShootShoot.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {
        protected override IConnector[] GetConnectors()
        {
            return new IConnector[]{
                new AudioManagerConnector(),
                new SaveDataConnector()
            };
        }

        protected override IController[] GetDependencies()
        {
            return new IController[]
            {
                new AudioManagerController(),
                new SaveDataController()
            };
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
            obj.AddComponent<InputSystemUIInputModule>();

            GameObject.DontDestroyOnLoad(obj);
        }

        private void CreateCamera()
        {
            GameObject obj = new ("Camera");
            obj.AddComponent<Camera>();
            obj.AddComponent<AudioListener>();
            obj.transform.Translate(Vector3.back * 10);

            GameObject.DontDestroyOnLoad(obj);
        }


    }
}
