using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] protected float HealthAmount;

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
