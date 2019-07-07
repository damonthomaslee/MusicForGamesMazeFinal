using System.Collections;
using System.Collections.Generic;
using SteamAudio;
using UnityEngine;

public class triggerAudio : MonoBehaviour
{
    AudioSource sound;
    void Start()
    {
        sound = GetComponent<AudioSource>();
  
    } 

    void OnTriggerEnter()
    {
        sound.Play ();

    }
    void OnTriggerExit()
    {
        sound.Stop ();

    }
}

