using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    void Start()
    {
        Instantiate(GameManager.instance.currentCharacter.prefab, transform.position, Quaternion.identity);
    }
}
