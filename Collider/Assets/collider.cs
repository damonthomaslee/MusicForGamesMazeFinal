using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour

{

    private Transform fiffy;
    // Start is called before the first frame update
    void Start()
    {

        fiffy = GameObject.Find("Cube").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.transform.position.y < -10)
        {
            Time.timeScale = 0f;
        }



    }


    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("box"))
        {
            print("Trigger Entered");
        }
    }


    private void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("box"))
        {
            print("trigger exited");
        }
    }
}
