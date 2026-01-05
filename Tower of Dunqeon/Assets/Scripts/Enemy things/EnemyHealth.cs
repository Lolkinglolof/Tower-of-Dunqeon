public class EnemyHealth : Health
{
    private void Awake()
    {
        HealthAmount = 50;
    }

    override public void OnDeath()
    {
        gameObject.SetActive(false);
    }
}
