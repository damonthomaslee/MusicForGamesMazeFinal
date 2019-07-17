using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdvanceScene : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;
    private int currentScene;

    void start()
    
    {
    Debug.Log(currentScene);   
    }

    private void OnTriggerEnter(Collider collision)
    {
        StartCoroutine(WaitForTime());
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
        
    }
}

