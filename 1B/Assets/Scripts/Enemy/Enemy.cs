using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject myManager;

    private void Start()
    {
        myManager = GameObject.FindGameObjectWithTag("GameManager");
        myManager.GetComponent<EnemyCount>().activeEnemies++;
    }

}
