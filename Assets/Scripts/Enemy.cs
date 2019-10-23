using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public int health = 3;

	public void take_damage (int damage)
	{
		health -= damage;

		if (health <= 0)
		{
			die();
		}
	
	}


	void die()
	{
		Destroy(gameObject);

	}




}
