using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    private void Awake()
    {
        HealthAmount = 50;
    }
    public void OnTakeDamage()
    {

    }
    override public void OnDeath()
    {
        gameObject.SetActive(false);
    }
}
