using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab = null;
    private Transform fire_point;
    private UI_Bar gun;

    public bool canShoot = true;

    private void Start()
    {
        fire_point = transform.GetChild(0).gameObject.transform;
        //gun = GetComponent<PlayerHealthBreatheAmmo>().ammo;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && canShoot) //Gathering user input fire1 is mouse0 (left mouse button)
        {
            if (GetComponent<PlayerHealthBreatheAmmo>().ammo.current > 0)
            {
                Shoot(); //calls the shoot function below
                GetComponent<PlayerHealthBreatheAmmo>().ammo.Deduct("ammo");
            }
        }
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, fire_point.position, fire_point.rotation); //Creates a bulletprefab at the fire_point's position
    }
}
