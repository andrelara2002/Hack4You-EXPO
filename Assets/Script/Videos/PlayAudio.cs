using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource sound;
    public AudioSource music;

    GameObject soundObject = GameObject.Find("BackgroundMusic");

    private void OnTriggerEnter(Collider other)
    {

        AudioSource backgroundMusic = soundObject.GetComponent<AudioSource>();

        if (sound.isPlaying)
        {
            sound.Pause();
            music.Pause();
        }
        else
        {
            music.Play();
            sound.Play();
        }
    }
}
