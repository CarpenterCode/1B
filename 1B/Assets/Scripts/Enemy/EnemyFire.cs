using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float shotForce;

    bool isGrounded;
    float _setTimer = 2;
    float _timer = 2;
    Rigidbody2D rb;


    private void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }



    private void Update()
    {
        _timer -= Time.deltaTime;
        if (_timer < 0.1 && isGrounded == false)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, bulletPrefab.transform.rotation);
            Rigidbody2D rigB = bullet.GetComponent<Rigidbody2D>();
            rigB.AddForce(-Vector2.up * shotForce, ForceMode2D.Impulse);
            _timer = _setTimer;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isGrounded = true;
    }

}
