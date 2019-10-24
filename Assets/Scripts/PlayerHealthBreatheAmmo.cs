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

    private void Start()
    {
        health = new UI_Bar(healthSlider, maxHealth);
        breathe = new UI_Bar(breatheSlider, maxBreathe);
        ammo = new UI_Bar(ammoSlider, maxAmmo);
    }
}

public class UI_Bar
{
    public Slider slider;
    public int max;
    public int current;

    public UI_Bar(Slider sld, int mx)
    {
        slider = sld;
        max = mx;
        current = max;
        slider.value = current;
    }

    public void Deduct()
    {
        if (current > 0)
        {
            current--;
            slider.value = current;
        } else
        {
            Debug.Log("Cannot deduct anymore");
        }
    }

    public void Deduct(string type)
    {
        if (current > 0)
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
                    break;
                case "breathe":
                    Debug.Log("You are out of breathe!");
                    break;
                case "ammo":
                    Debug.Log("You are out of ammo!");
                    break;
                default:
                    break;
            }
        }
    }
}