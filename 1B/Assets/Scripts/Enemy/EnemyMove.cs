using UnityEngine;
using UnityEngine.UI;

public class EnemyMove : MonoBehaviour
{

    [SerializeField] GameObject enemyFurnace, gameManager, scorePlus, scream;
    [SerializeField] float moveSpeed;

    GameObject shakeMe;
    Rigidbody2D rb;
    int myLevel;

    private void Start()
    {
        shakeMe = GameObject.FindGameObjectWithTag("ScreenShake");
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        myLevel = gameManager.GetComponent<NextLevel>().currentLevel;

        switch (myLevel)
        {
            case 2:
                moveSpeed = 1.25f;
                break;
            case 4:
                moveSpeed = 1.6f;
                break;
            case 6:
                moveSpeed = 2.1f;
                break;
            case 8:
                moveSpeed = 2.35f;
                break;
            case 10:
                moveSpeed = 2.6f;
                break;
        }
    }

    private void FixedUpdate()
    {
        rb.position -= Vector2.up * moveSpeed * Time.fixedDeltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Furnace")
        {
            //PlayRandomSound();
            ShowScore();
            shakeMe.GetComponent<ShakeScreen>().ScreenShake();
            Instantiate(enemyFurnace, transform.position, Quaternion.identity);
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<ScoreCount>().points += 20;
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<EnemyCount>().activeEnemies--;
            Destroy(this.gameObject);
        }
    }

    void ShowScore()
    {
        GameObject myScream = Instantiate(scream, transform.position, Quaternion.identity);
        GameObject myScore = Instantiate(scorePlus, transform.position, Quaternion.identity);
        Destroy(myScream, 3);
        Destroy(myScore, 1);
    }
   
}
