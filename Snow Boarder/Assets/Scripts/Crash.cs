using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] float deathDelay = 0.5f;
    [SerializeField] ParticleSystem deathEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground") // if the player collides with the ground do sum
        {
            deathEffect.Play();
            Invoke("ReloadScene", deathDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
