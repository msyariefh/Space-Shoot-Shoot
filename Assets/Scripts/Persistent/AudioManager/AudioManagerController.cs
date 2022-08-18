using Agate.MVC.Base;
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

    }
}

