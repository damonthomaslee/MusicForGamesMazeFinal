using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingFaster : MonoBehaviour
{
    public int scale;
    public float distanceNow;
    public AudioSource AudioSource;
    //public float pitch;

    private float startDistance;
    private GameObject Goal;


    private float DistanceToPitch()
    {
        float pitch;
        float distance;


        distance = Vector3.Distance(Goal.transform.position, transform.position) / scale;
        pitch = 1 + (startDistance - distance) * (1 / startDistance);

        return pitch;
    }
    


    // Start is called before the first frame update
    void Start()
    {
        Goal = GameObject.Find("Goal");

        scale = 1;
        startDistance = Vector3.Distance(Goal.transform.position, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        distanceNow = Vector3.Distance(Goal.transform.position, transform.position);

        AudioSource.pitch = DistanceToPitch();

        if (Input.GetKey("k") && AudioSource.isPlaying == false)
        {
            AudioSource.Play();
        }

        if (Input.GetKeyUp("k"))
        {
            AudioSource.Stop();
        }

    }

}
