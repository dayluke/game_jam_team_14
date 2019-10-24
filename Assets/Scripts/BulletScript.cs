using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField]
    private const float speed = 5f; //The speed of the projectile

    private Rigidbody2D rb;
    private const int damage = 1; //The amount of health that is removed from the enemy
    private const int lifeTime = 3;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        Destroy(gameObject, lifeTime); // This destroys the bullet once it collides with something
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        EnemyScript enemy = coll.GetComponent<EnemyScript>(); //Finding out if it hit an enemy object
        if (enemy != null) //If enemy, or what was hit is something then it will cause that to take damage
        {
            enemy.DeductHealth(damage);
        }
        Destroy(gameObject); //This destroys the bullet once it collides with something
    }
}
