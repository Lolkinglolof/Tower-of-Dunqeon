using UnityEngine;

public class Weapon : MonoBehaviour
{
    protected int damage = 50;
    protected string targetTag = "enemy";
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.ToLower() == targetTag)
        {
            HitTarget(other);
        }
    }
    virtual public void HitTarget(Collider other)
    {
        other.gameObject.GetComponent<Health>().OnTakeDamage(damage);
    }
}
