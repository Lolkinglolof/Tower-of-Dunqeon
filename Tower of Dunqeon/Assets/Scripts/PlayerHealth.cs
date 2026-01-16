using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : Health
{
    public float maxHealth = 100;
    public Slider healthSlider;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
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
        SceneManager.LoadScene(0);
    }
    public override void OnTakeDamage(int DamageAmount)
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("TestBlock"))
        {
            DamageAmount = Mathf.RoundToInt(DamageAmount/2);
        }
        base.OnTakeDamage(DamageAmount);
    }
}
