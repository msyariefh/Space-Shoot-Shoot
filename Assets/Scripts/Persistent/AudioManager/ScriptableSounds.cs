using UnityEngine;

namespace SpaceShootShoot.Persistent.AudioManager
{
    [CreateAssetMenu]
    public class ScriptableSounds : ScriptableObject
    {
        [SerializeField] private Sound[] _sounds;

        public string _mainMenuBGM;
        public string _gameplayBMG;
        public Sound[] Sounds()
        {
            Sound[] returnableArray = new Sound[_sounds.Length];
            System.Array.Copy(_sounds, returnableArray, _sounds.Length);
            return returnableArray;
        }
    }
}

