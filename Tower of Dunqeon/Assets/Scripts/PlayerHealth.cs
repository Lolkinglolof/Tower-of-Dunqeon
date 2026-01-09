using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100;
    public float maxHealth = 100;
    public Slider healthSlider;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        healthSlider.maxValue = maxHealth;
        healthSlider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = health;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
