using FMOD.Studio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsVolume : MonoBehaviour
{
    [SerializeField] private Slider sound;
    [SerializeField] private Slider music;
    [SerializeField] private Slider vfx;

    [SerializeField] private Bus soundBus;
    [SerializeField] private Bus musicBus;
    [SerializeField] private Bus vfxBus;

    public void ChangeSound() =>
        soundBus.setVolume(sound.value);

    public void ChangeMusic() =>
        musicBus.setVolume(music.value);

    public void ChangeVFX() =>
        vfxBus.setVolume(vfx.value);
}
