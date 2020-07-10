using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] GameObject enemyExplosion, screenShake, scorePlus;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5f);
        screenShake = GameObject.FindGameObjectWithTag("ScreenShake");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            screenShake.GetComponent<ShakeScreen>().ScreenShake();
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<ScoreCount>().points += 10;
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<EnemyCount>().activeEnemies--;
            Instantiate(enemyExplosion, transform.position, Quaternion.identity);
            ShowScore();
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
    
    void ShowScore()
    {
        GameObject score = Instantiate(scorePlus, transform.position, Quaternion.identity);
        Destroy(score, 1);
    }

}
