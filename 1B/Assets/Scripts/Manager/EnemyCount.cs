using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCount : MonoBehaviour
{
    [SerializeField] GameObject endScreen;
    [SerializeField] Text enemyCount;

    public int activeEnemies = 0;


    private void Update()
    {
        enemyCount.text = activeEnemies.ToString();

        if (activeEnemies >= 10)
        {
            endScreen.SetActive(true);
            endScreen.GetComponent<RestartGame>().isActive = true;
        }
    }


}
