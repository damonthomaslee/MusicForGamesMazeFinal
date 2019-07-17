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
     public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime) {
            float startVolume = audioSource.volume;
            while (audioSource.volume > 0) {
                audioSource.volume -= startVolume * Time.deltaTime / FadeTime;
                yield return null;
            }
            audioSource.Stop();
        }public static IEnumerator FadeIn(AudioSource audioSource, float FadeTime) {
            audioSource.Play();
            audioSource.volume = 0f;
            while (audioSource.volume < 1) {
                audioSource.volume += Time.deltaTime / FadeTime;
                yield return null;
            }
        }

    void OnTriggerEnter()
    {
        sound.Play();
        StartCoroutine(FadeIn(sound, 3f));

    }
    void OnTriggerExit()
    {
        StartCoroutine(FadeOut(sound, 3));
        sound.Stop ();

    }
}

