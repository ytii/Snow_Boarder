using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    
    public static GameManager instance;

    public Character[] characters;

    public Character currentCharacter;

    private void Awake() {
        if (instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Start() {
        if (characters.Length > 0) {
            currentCharacter = characters[0];
        }
    }

    public void SetCharacter(Character character) {
        currentCharacter = character;
    }
}