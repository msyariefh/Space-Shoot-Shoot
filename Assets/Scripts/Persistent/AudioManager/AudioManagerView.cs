using Agate.MVC.Base;
using System;
using UnityEngine;

namespace SpaceShootShoot.Persistent.AudioManager
{
    public class AudioManagerView : ObjectView<IAudioManagerModel>
    {
        [SerializeField] private string _bgmForScene;
        protected override void InitRenderModel(IAudioManagerModel model)
        {
            foreach(Sound sound in model.Sounds)
            {
                sound.Source = gameObject.AddComponent<AudioSource>();
                sound.Source.clip = sound.Clip;
                sound.Source.volume = sound.Volume;
                sound.Source.pitch = sound.Pitch;
                sound.Source.loop = sound.IsLooping;
                sound.Source.playOnAwake = false;
            }
            PlayAudioSourceFromList(model.Sounds, _bgmForScene, true);
        }

        protected override void UpdateRenderModel(IAudioManagerModel model)
        {
            PlayAudioSourceFromList(model.Sounds, model.SFX, false);
        }

        private void PlayAudioSourceFromList(Sound[] sounds, string audioName, bool isBGM)
        {
            if (audioName == null) return;
            AudioSource audioSource;
            if (isBGM)
            {
                audioSource = Array.Find(sounds, s => s.IsBGM == true && s.Name == audioName)?.Source;
                if (audioSource == null)
                {
                    Debug.LogWarning($"BGM {audioName} can't be found! \nMake sure to enter the correct name");
                    return;
                }
                if (audioSource.isPlaying) return;
                print(audioSource.clip);
                audioSource.Play();
                print(audioSource.isPlaying);
                return;
            }

            audioSource = Array.Find(sounds, s => s.IsBGM == false && s.Name == audioName).Source;
            audioSource.Play();
        }
    }
}

