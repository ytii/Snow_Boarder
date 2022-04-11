using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] float deathDelay = 2f;
    [SerializeField] ParticleSystem deathEffect;
    Rigidbody2D rb2d;

    bool isDead = false;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground" && !isDead) // if the player collides with the ground do sum
        {
            isDead = true;
            FindObjectOfType<PlayerController>().DisableControls();
            deathEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", deathDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(Death);
    }
}
