using Agate.MVC.Base;

namespace SpaceShootShoot.Persistent.AudioManager
{
    public class AudioManagerModel : BaseModel, IAudioManagerModel
    {
        public Sound[] Sounds { get; private set; }
        public string BGM { get; private set; }
        public string SFX { get; private set; }


        public void SetSounds(Sound[] sounds)
        {
            Sounds = sounds;
            SetDataAsDirty();
        }

        public void SetBGM(string name)
        {
            BGM = name;
            SetDataAsDirty();
        }

        public void SetSFX(string name)
        {
            SFX = name;
            SetDataAsDirty();
        }

    }
}

