using UnityEngine;

public class EnemyHealth : Health
{
    private void Awake()
    {
        HealthAmount = 50;
    }
    public override void OnTakeDamage(int DamageAmount)
    {
        Debug.Log("Enemyhit");
        base.OnTakeDamage(DamageAmount);
    }
    override public void OnDeath()
    {
        gameObject.SetActive(false);
    }
}
