using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    protected int damage;
    protected string targetTag;
    public List<GameObject> targets;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.ToLower() == targetTag && !targets.Contains(other.gameObject))
        {
            HitTarget(other);
            targets.Add(other.gameObject);
        }
    }
    virtual public void HitTarget(Collider other)
    {
        other.gameObject.GetComponent<Health>().OnTakeDamage(damage);
    }
}
