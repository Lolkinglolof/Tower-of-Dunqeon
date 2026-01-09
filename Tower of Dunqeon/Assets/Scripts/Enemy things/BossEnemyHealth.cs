using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemyHealth : EnemyHealth
{
    private void Awake()
    {
        HealthAmount = 1000;
    }
    public override void OnTakeDamage(int DamageAmount)
    {
        Debug.Log("Bosshit");
        base.OnTakeDamage(DamageAmount);
    }
}
