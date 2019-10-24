using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    private int speed = 1;

    private GameObject player;
    private int health = 3;
    private bool canAttack = true;
    private float visionRadius = 3f;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void LateUpdate()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < visionRadius)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }

    public void DeductHealth(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Player") && canAttack)
        {
            player.GetComponent<PlayerHealthBreatheAmmo>().health.Deduct();
            canAttack = false;
        }
    }

    private void OnCollisionExit2D()
    {
        canAttack = true;
    }
}
