using System.Runtime.CompilerServices;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float HealthAmount = 100f;

    virtual public void OnTakeDamage(int DamageAmount)
    {
        HealthAmount -= DamageAmount;
        if (HealthAmount < 0)
        {
            OnDeath();
        }
    }
    virtual public void OnDeath()
    {
        // do death thing
    }



}
