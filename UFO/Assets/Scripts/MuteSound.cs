using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteSound : MonoBehaviour
{
    public GameObject audioSource;
    public void Mute()
    {
        audioSource.GetComponent<AudioSource>().mute = !audioSource.GetComponent<AudioSource>().mute;
    }
}
