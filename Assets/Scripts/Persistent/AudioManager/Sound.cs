using UnityEngine;

namespace SpaceShootShoot.Persistent.AudioManager
{
    [System.Serializable]
    public class Sound
    {
        [SerializeField] private string _name;
        [SerializeField] private AudioClip _clip;
        [Range(0f, 1f)] [SerializeField] private float _volume;
        [Range(0f, 1f)] [SerializeField] private float _pitch;
        [SerializeField] private bool _isLooping;
        [SerializeField] private bool _isBGM;
        [SerializeField] private AudioSource _source;

        public string Name => _name;
        public AudioClip Clip => _clip;
        public float Volume => _volume;
        public float Pitch => _pitch;
        public bool IsLooping => _isLooping;
        public bool IsBGM => _isBGM;
        public AudioSource Source
        {
            get { return _source; }
            set { _source = value; }
        }
    }
}

