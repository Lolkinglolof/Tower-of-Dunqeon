using System.Runtime.CompilerServices;
using UnityEngine;

public class Health : MonoBehaviour
{
    protected float HealthAmount = 50;

    virtual public void OnTakeDamage(int DamageAmount)
    {
        HealthAmount -= DamageAmount;
        if (HealthAmount <= 0)
        {
            OnDeath();
        }
    }
    virtual public void OnDeath()
    {
        // do death thing
    }



}
