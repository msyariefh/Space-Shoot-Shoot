using Agate.MVC.Base;
using SpaceShootShoot.Message;
using System.Collections;
using UnityEngine;

namespace SpaceShootShoot.Persistent.AudioManager
{
    public class AudioManagerController : ObjectController<AudioManagerController, AudioManagerModel, IAudioManagerModel, AudioManagerView>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            ScriptableSounds scriptableSounds = Resources.Load<ScriptableSounds>("Audio/SoundsForGame");
            _model.SetSounds(scriptableSounds.Sounds());
        }

        public void OnPlayerShoot(PlayerShootMessage message)
        {
            _model.SetSFX("PlayerShootSFX");
        }

    }
}

