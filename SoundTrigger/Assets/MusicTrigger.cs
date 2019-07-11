using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
   
    
    // Start is called before the first frame update
    void Start()
    {

       ;
        gameObject.GetComponent<AudioSource>().playOnAwake = false;
        

    }

    // Update is called once per frame


    private void OnCollisionEnter(Collision other)
    {
        gameObject.GetComponent<AudioSource>().Play();
    }
}
