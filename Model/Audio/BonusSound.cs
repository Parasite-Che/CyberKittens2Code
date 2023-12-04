using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSound : MonoBehaviour
{
    private AudioSource audioPlayer;
    private float volume;

    private void Start()
    {
        Events.onEffectPlay += PlaySound;
        audioPlayer = GetComponent<AudioSource>();
        volume = 3*PlayerPrefs.GetFloat("SoundsValue")/4+PlayerPrefs.GetFloat("SoundsValue")/4;
        audioPlayer.volume = volume;
    }

    void PlaySound(AudioClip clip)
    {
        audioPlayer.PlayOneShot(clip);
    }
}
