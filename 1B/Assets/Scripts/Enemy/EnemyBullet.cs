
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    [SerializeField] GameObject endScreen;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            endScreen.SetActive(true);
            endScreen.GetComponent<RestartGame>().isActive = true;
        }
        if (collision.tag == "Bullet")
        {
            Destroy(collision.gameObject);
        }
        if (collision.tag == "Enemy")
        {
            return;
        }
        Destroy(this.gameObject);
    }

}
