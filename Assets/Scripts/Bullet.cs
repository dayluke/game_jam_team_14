using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour{

	public float speed = 20f; //The speed of the projectile
	public Rigidbody2D rigid_body;
	public int damage = 1; //The amount of health that is removed from the enemy


    // Start is called before the first frame update
    void Start()
    {
		    rigid_body.velocity = transform.right * speed;   
    }

    void OnTriggerEnter2D (Collider2D hit_info)
	{
		Enemy enemy = hit_info.GetComponent<Enemy>(); //Finding out if it hit an enemy object
		if (enemy != null) //If enemy, or what was hit is something then it will cause that to take damage
		{
			enemy.take_damage(damage);
		}
		Destroy(gameObject); //This destroys the bullet once it collides with something
	}
   
}
