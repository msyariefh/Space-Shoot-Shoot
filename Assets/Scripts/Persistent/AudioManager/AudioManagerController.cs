using Agate.MVC.Base;
using System.Collections;

namespace SpaceShootShoot.Persistent.AudioManager
{
    public class AudioManagerController : ObjectController<AudioManagerController, AudioManagerModel, IAudioManagerModel, AudioManagerView>
    {
        private ScriptableSounds _scrSounds;

        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            _model.SetSounds(_scrSounds.Sounds);
            _model.SetBGM(_scrSounds._mainMenuBGM);
            //GameObject.DontDestroyOnLoad(_view);
        }

    }
}

