using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource sound;
    public AudioSource music;

    private void OnTriggerEnter(Collider other)
    {

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
