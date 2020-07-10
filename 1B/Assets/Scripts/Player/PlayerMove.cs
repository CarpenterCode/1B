using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] AudioSource myAs;
    [SerializeField] GameObject bulletPrefab, reloadPrefab;
    [SerializeField] Transform firePoint, reloadPoint;
    [SerializeField] float moveSpeed, shotSpeed;

    float setTimer = 0.5f;
    bool goingRight;
    Rigidbody2D rb;

    private void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        setTimer -= Time.deltaTime;

       

        if (Input.GetKeyDown(KeyCode.Space))
        {
            goingRight = true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            goingRight = false;

            if (setTimer <= 0)
            {
            Shoot();
            }
        }
    }

    private void FixedUpdate()
    {
        if (goingRight == false)
        {
        rb.position += Vector2.left * moveSpeed * Time.fixedDeltaTime;
        }
        if (goingRight == true)
        {
            rb.position -= Vector2.left * moveSpeed * Time.fixedDeltaTime;
        }
        
    }

    void Shoot()
    {
        Instantiate(reloadPrefab, reloadPoint.position, Quaternion.identity);
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D bullRB = bullet.GetComponent<Rigidbody2D>();
        bullRB.AddForce(Vector2.up * shotSpeed, ForceMode2D.Impulse);
        setTimer = 0.5f;
        myAs.Play();
    }

   


}
