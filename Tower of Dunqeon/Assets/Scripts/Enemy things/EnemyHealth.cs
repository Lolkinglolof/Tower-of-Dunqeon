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
