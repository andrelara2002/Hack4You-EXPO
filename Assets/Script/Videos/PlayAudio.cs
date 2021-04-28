using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource sound;

    private void OnTriggerEnter(Collider other)
    {

        if (sound.isPlaying)
        {
            sound.Pause();
        }
        else
        {
            sound.Play();
        }
    }
}
