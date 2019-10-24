using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBreatheAmmo : MonoBehaviour
{
    [SerializeField]
    private Slider healthSlider = null, breatheSlider = null, ammoSlider = null;
    public UI_Bar health = null, breathe = null, ammo = null;
    
    private const int maxHealth = 5, maxBreathe = 5, maxAmmo = 6;
    private int regenTimer = 10;
    private PlayerMovement playerScript = null;

    private void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();

        health = new UI_Bar(healthSlider, maxHealth, playerScript);
        breathe = new UI_Bar(breatheSlider, maxBreathe, playerScript);
        ammo = new UI_Bar(ammoSlider, maxAmmo, playerScript);
        StartCoroutine(RegenUI(breathe));
        StartCoroutine(RegenUI(ammo));
    }

    private void Update()
    {
        if (breathe.current > 0)
        {
            playerScript.canJump = true;
        }

        if (ammo.current > 0)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerWeapon>().canShoot = true;
        }
        Debug.Log(breathe.current);
    }

    private IEnumerator RegenUI(UI_Bar ui)
    {
        while (true)
        {
            if (ui.current < ui.max)
            {
                yield return new WaitForSeconds(regenTimer);
                ui.Increase();
            }
            else
            { 
                yield return null;
            }
        }
    }
}

public class UI_Bar
{
    public Slider slider;
    public int max;
    public int current;
    private PlayerMovement player;

    public UI_Bar(Slider sld, int mx, PlayerMovement playerScript)
    {
        slider = sld;
        max = mx;
        current = max;
        slider.value = current;
        player = playerScript;
    }

    public void Increase()
    {
        if (current < max)
        {
            current++;
            slider.value = current;
        }
    }    

    public void Deduct(string type)
    {
        if (current >= 1)
        {
            current--;
            slider.value = current;
        }
        else
        {
            switch (type)
            {
                case "health":
                    Debug.Log("You died!");
                    current = max;
                    slider.value = current;
                    player.Respawn();
                    break;
                case "breathe":
                    Debug.Log("You are out of breathe!");
                    player.canJump = false;
                    break;
                case "ammo":
                    Debug.Log("You are out of ammo!");
                    GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerWeapon>().canShoot = false;
                    break;
                default:
                    break;
            }
        }
    }
}