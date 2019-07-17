using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifferentCollision : MonoBehaviour
{

    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GameObject.Find("Cube").GetComponent<AudioSource>();

    }

    private void OnCollisionEnter(Collision other)
    {
        audio.Play();
    }
}
