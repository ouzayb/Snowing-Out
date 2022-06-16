using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSettings : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetLevel(float slidervalue){
        mixer.SetFloat("MainMusicVolume", Mathf.Log10(slidervalue)*20);
    }
}
