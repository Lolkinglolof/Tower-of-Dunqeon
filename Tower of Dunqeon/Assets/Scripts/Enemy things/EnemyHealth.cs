public class EnemyHealth : Health
{
    private void Awake()
    {
        HealthAmount = 50;
    }
    public override void OnTakeDamage(int DamageAmount)
    {
        base.OnTakeDamage(DamageAmount);
    }
    override public void OnDeath()
    {
        gameObject.SetActive(false);
    }
}
