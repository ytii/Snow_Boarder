using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] float deathDelay = 0.5f;
    [SerializeField] ParticleSystem deathEffect;
    [SerializeField] PlayerController playerController;
    Rigidbody2D rb2d;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        playerController = GetComponent<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground") // if the player collides with the ground do sum
        {
            deathEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", deathDelay);
            playerController.enabled = false;
            rb2d.gravityScale = 5f; // *kinda* prevents bouncing and spamming audio
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
