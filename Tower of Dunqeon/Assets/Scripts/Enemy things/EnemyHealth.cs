using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    float HealthAmount = 50;

    void OnDeath()
    {
        gameObject.SetActive(false);
    }
}
