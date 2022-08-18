using Agate.MVC.Base;
namespace SpaceShootShoot.Persistent.AudioManager
{
    public interface IAudioManagerModel : IBaseModel
    {
        public Sound[] Sounds { get; }
        public string BGM { get; }
        public string SFX { get; }
    }
}

