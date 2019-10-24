using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab = null;
    private Transform fire_point;

    private void Start()
    {
        fire_point = transform.GetChild(0).gameObject.transform;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) //Gathering user input fire1 is mouse0 (left mouse button)
        {
            Shoot(); //calls the shoot function below
        }
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, fire_point.position, fire_point.rotation); //Creates a bulletprefab at the fire_point's position
    }
}
