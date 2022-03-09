using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] float finishDelay = 2f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player") // if the player collides with the finish line do sum
        {
            Invoke("ReloadScene", finishDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
