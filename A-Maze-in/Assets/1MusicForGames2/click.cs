using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    
    [SerializeField] float firingPeriod = 0.7f;

    Coroutine firingCoroutine;
    // Update is called once per frame

    AudioSource audioData;
    
   

    void Start()
    {
        audioData = GetComponent<AudioSource>();
        //audioData.Play(0);
        Debug.Log("started");
    
    }
    void Update()
    {
        Fire();
    }


    private void Fire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            firingCoroutine = StartCoroutine(FireContinuously());
        }
        if (Input.GetButtonUp("Fire1"))
        {
            StopCoroutine(firingCoroutine);
            // StopAllCoroutines(); brutal, also a solution...
        }
    }
    IEnumerator FireContinuously()
    {
        while (true)
        {
            audioData.Play(0);
            yield return new WaitForSeconds(firingPeriod);
        }
    }


}
