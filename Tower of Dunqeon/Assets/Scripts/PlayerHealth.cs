using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : Health
{
    public float maxHealth = 100;
    public Slider healthSlider;
    // Start is called before the first frame update
    void Start()
    {
        HealthAmount = maxHealth;
        healthSlider.maxValue = maxHealth;
        healthSlider.value = HealthAmount;
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = HealthAmount;
    }
    public override void OnDeath()
    {
        base.OnDeath();
        // go to death menu
    }
}
