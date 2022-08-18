using Agate.MVC.Base;
using System;
using UnityEngine;

namespace SpaceShootShoot.Persistent.AudioManager
{
    public class AudioManagerView : ObjectView<IAudioManagerModel>
    {
        private string _currectBGMPlayed;
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
            FindAudioSource(model.Sounds, model.BGM, true)?.Play();
            _currectBGMPlayed = model.BGM;
        }

        protected override void UpdateRenderModel(IAudioManagerModel model)
        {
            if (model.BGM != _currectBGMPlayed)
            {
                FindAudioSource(model.Sounds, _currectBGMPlayed, true)?.Stop();
                _currectBGMPlayed = model.BGM;
                FindAudioSource(model.Sounds, model.BGM, true)?.Play();
            }

            FindAudioSource(model.Sounds, model.SFX, false)?.Play();

        }

        private AudioSource FindAudioSource(Sound[] sounds, string name, bool isBGM)
        {
            return Array.Find(sounds, sound => sound.Name == name && 
            sound.IsBGM == isBGM).Source;
        }
    }
}

