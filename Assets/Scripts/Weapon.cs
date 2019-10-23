using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform fire_point;
	public GameObject bulletPrefab;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) //Gathering user input fire1 is mouse0 (left mouse button)
		{
			shoot(); //calls the shoot function below
		}
    }

	void shoot()
	{
		Instantiate(bulletPrefab, fire_point.position, fire_point.rotation); //Creates a bulletprefab at the fire_point's position
	}
}
