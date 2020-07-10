using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] GameObject enemyPrefab, gameManager;


    Transform[] spawnPoints;

    int myLevel;
    float _timer = 1;
    float _setTimer = 3f;

    private void Start()
    {
        spawnPoints = new Transform[transform.childCount];

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            spawnPoints[i] = transform.GetChild(i);    
        }


    }

    private void Update()
    {

        myLevel = gameManager.GetComponent<NextLevel>().currentLevel;
        
        _timer -= Time.deltaTime;
        
        if (_timer < 0.1f)
        {
            Instantiate(enemyPrefab, spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);
            _timer = _setTimer;
        }

        switch (myLevel)
        {
            case 1:
                break;
            case 2:
                _setTimer = 2.75f;
                break;
            case 3:
                _setTimer = 2.5f;
                break;
            case 4:
                _setTimer = 2.25f;
                break;
            case 5:
                _setTimer = 2f;
                break;
            case 6:
                _setTimer = 1.75f;
                break;
            case 7:
                _setTimer = 1.75f;
                break;
            case 8:
                _setTimer = 1.5f;
                break;
            default:
                _setTimer = 1.5f;
                break;

        }

    }


}
