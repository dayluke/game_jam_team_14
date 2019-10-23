using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBreatheAmmo : MonoBehaviour
{
    public Slider healthSlider = null, breatheSlider = null, ammoSlider = null;
    public UI_Bar health = null, breathe = null, ammo = null;
    
    private const int maxHealth = 100, maxBreathe = 100, maxAmmo = 7;

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

    public void Deduct(int amount)
    {
        current -= amount;
        slider.value = current;
    }
}
