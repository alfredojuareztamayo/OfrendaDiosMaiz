using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioListener2 : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audio;
    // Start is called before the first frame update
     void Start()
    {
        audio= GetComponent<AudioSource>();
    }

    public void PlayAudio()
    {
        audio.Play();
    }
}
