using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    [SerializeField] GameObject endScreen;
    GameObject playerObject;

    private void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnemyBullet")
        {
            endScreen.SetActive(true);
            endScreen.GetComponent<RestartGame>().isActive = true;
            Destroy(playerObject);
        }
    }
}
